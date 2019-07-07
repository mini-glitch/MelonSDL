using System;
using System.IO;
using SDL2;
using StbSharp;

namespace Melon
{
	public struct Color
	{
		public byte r;
		public byte g;
		public byte b;
		public byte a;

		public static Color white => new Color(255, 255, 255);
		public static Color black => new Color(0, 0, 0);
		public static Color red => new Color(255, 0, 0);
		public static Color green => new Color(0, 255, 0);
		public static Color blue => new Color(0, 0, 255);
		public static Color yellow => new Color(255, 255, 0);
		public static Color cyan => new Color(0, 255, 255);
		public static Color magenta => new Color(255, 0, 255);
		public static Color clear => new Color(0, 0, 0, 0);

		public Color(byte r, byte g, byte b, byte a = 255)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		internal Color(SDL.SDL_Color color)
		{
			r = color.r;
			g = color.g;
			b = color.b;
			a = color.a;
		}

		internal SDL.SDL_Color ToSDLColor() => new SDL.SDL_Color { r = r, g = g, b = b, a = a };
	}

	public struct Rect
	{
		public float x;
		public float y;
		public float w;
		public float h;

		public Rect(float x, float y, float w, float h)
		{
			this.x = x;
			this.y = y;
			this.w = w;
			this.h = h;
		}

		internal SDL_gpu.GPU_Rect ToGPURect() => new SDL_gpu.GPU_Rect { x = x, y = y, w = w, h = h };
	}

	public class Image
	{
		internal IntPtr Ptr; // GPU_Image*
		public int Width { get; private set; }
		public int Height { get; private set; }

		private Color _color;
		public Color Color
		{
			get { return _color; }
			set
			{
				_color = value;
				SDL_gpu.GPU_SetRGBA(Ptr, _color.r, _color.g, _color.b, _color.a);
			}
		}
		
		internal Image(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		~Image()
		{
			if (Ptr != IntPtr.Zero)
			{
				SDL_gpu.GPU_FreeImage(Ptr);
				Ptr = IntPtr.Zero;
			}
		}
	}

	public class RenderTarget
	{
		internal IntPtr TargetPtr; // GPU_Target*;
		internal IntPtr ImagePtr; // GPU_Image*;
		public int Width { get; private set; }
		public int Height { get; private set; }

		internal RenderTarget(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		~RenderTarget()
		{
			if (TargetPtr != IntPtr.Zero && ImagePtr != IntPtr.Zero)
			{
				SDL_gpu.GPU_FreeTarget(TargetPtr);
				TargetPtr = IntPtr.Zero;	
				ImagePtr = IntPtr.Zero;
			}
		}
	}

    public static class Graphics
    {
		public enum DrawMode
		{
			Line,
			Fill
		}

		internal static IntPtr MainScreen { get; set; }

		#region Global state
		private static SDL.SDL_Color _backgroundColor;
		#endregion

		#region Color state
		public static void SetBackgroundColor(Color color)
		{
			SetBackgroundColor(color.r, color.g, color.b);
		}

		public static void SetBackgroundColor(byte r, byte g, byte b)
		{
			_backgroundColor.r = r;
			_backgroundColor.g = g;
			_backgroundColor.b = b;
		}
		public static Color GetBackgroundColor() => new Color(_backgroundColor);

		public static void ClearRenderTarget(RenderTarget target, Color color)
		{
			SDL_gpu.GPU_ClearRGB(target.TargetPtr, color.r, color.g, color.b);
		}
		#endregion

		#region Shapes
		public static void Pixel(float x, float y, Color color, RenderTarget target = null)
		{
			SDL_gpu.GPU_Pixel(target?.TargetPtr ?? MainScreen, x, y, color.ToSDLColor());
		}

		public static void Line(float x1, float y1, float x2, float y2, Color color, RenderTarget target = null)
		{
			SDL_gpu.GPU_Line(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, color.ToSDLColor());
		}

		public static void Circle(DrawMode mode, float x, float y, float radius, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Circle(target?.TargetPtr ?? MainScreen, x, y, radius, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_CircleFilled(target?.TargetPtr ?? MainScreen, x, y, radius, color.ToSDLColor()); break;
			}
		}

		public static void Arc(DrawMode mode, float x, float y, float radius, float start_angle, float end_angle, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Arc(target?.TargetPtr ?? MainScreen, x, y, radius, start_angle, end_angle, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_ArcFilled(target?.TargetPtr ?? MainScreen, x, y, radius, start_angle, end_angle, color.ToSDLColor()); break;
			}
		}

		public static void Ellipse(DrawMode mode, float x, float y, float rx, float ry, float degrees, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Ellipse(target?.TargetPtr ?? MainScreen, x, y, rx, ry, degrees, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_EllipseFilled(target?.TargetPtr ?? MainScreen, x, y, rx, ry, degrees, color.ToSDLColor()); break;
			}
		}

		public static void Sector(DrawMode mode, float x, float y, float inner_radius, float outer_radius, float start_angle, float end_angle, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Sector(target?.TargetPtr ?? MainScreen, x, y, inner_radius, outer_radius, start_angle, end_angle, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_SectorFilled(target?.TargetPtr ?? MainScreen, x, y, inner_radius, outer_radius, start_angle, end_angle, color.ToSDLColor()); break;
			}
		}

		public static void Triangle(DrawMode mode, float x1, float y1, float x2, float y2, float x3, float y3, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Tri(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, x3, y3, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_TriFilled(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, x3, y3, color.ToSDLColor()); break;
			}
		}

		public static void Rectangle(DrawMode mode, float x1, float y1, float x2, float y2, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Rectangle(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_RectangleFilled(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, color.ToSDLColor()); break;
			}
		}

		public static void RectangleRounded(DrawMode mode, float x1, float y1, float x2, float y2, float radius, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_RectangleRound(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, radius, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_RectangleRoundFilled(target?.TargetPtr ?? MainScreen, x1, y1, x2, y2, radius, color.ToSDLColor()); break;
			}
		}

		public static void Polygon(DrawMode mode, float[] vertices, Color color, RenderTarget target = null)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Polygon(target?.TargetPtr ?? MainScreen, (uint)vertices.Length / 2, vertices, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_PolygonFilled(target?.TargetPtr ?? MainScreen, (uint)vertices.Length / 2, vertices, color.ToSDLColor()); break;
			}
		}
		#endregion

		#region Images

		public static Image NewImage(string filepath)
		{
			byte[] fileBytes = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), filepath));
			return NewImage(fileBytes);
		}

		/// <summary>
		/// Returns a new Image reference
		/// </summary>
		/// <param name="bytes">Array of raw bytes from an image file</param>
		/// <returns>Image object</returns>
		public static Image NewImage(byte[] bytes)
		{
			var stbImage = StbImage.LoadFromMemory(bytes);
			Image image = new Image(stbImage.Width, stbImage.Height);

			SDL_gpu.GPU_FormatEnum format = SDL_gpu.GPU_FormatEnum.GPU_FORMAT_RGB;
			switch (stbImage.Comp)
			{
				case 3: format = SDL_gpu.GPU_FormatEnum.GPU_FORMAT_RGB; break;
				case 4: format = SDL_gpu.GPU_FormatEnum.GPU_FORMAT_RGBA; break;
				default: break;
			}

			image.Ptr = SDL_gpu.GPU_CreateImage((ushort)image.Width, (ushort)image.Height, format);
			var rect = new SDL_gpu.GPU_Rect { x = 0, y = 0, w = image.Width, h = image.Height };
			SDL_gpu.GPU_UpdateImageBytes(image.Ptr, ref rect, stbImage.Data, stbImage.Width * stbImage.Comp);

			return image;
		}

		public static void DrawImage(Image image, float x, float y, RenderTarget target = null)
		{
			var rect = new SDL_gpu.GPU_Rect { x = 0, y = 0, w = image.Width, h = image.Height };
			SDL_gpu.GPU_Blit(image.Ptr, ref rect, target?.TargetPtr ?? MainScreen, x, y);
		}
		
		public static void DrawImage(Image image, Rect rect, float x, float y, RenderTarget target = null)
		{
			var gpuRect = rect.ToGPURect();
			SDL_gpu.GPU_Blit(image.Ptr, ref gpuRect, target?.TargetPtr ?? MainScreen, x, y);
		}

		#endregion

		#region RenderTarget
		public static RenderTarget NewRenderTarget(int width, int height)
		{
			IntPtr image = SDL_gpu.GPU_CreateImage((ushort)width, (ushort)height, SDL_gpu.GPU_FormatEnum.GPU_FORMAT_RGB);
			SDL_gpu.GPU_SetImageFilter(image, SDL_gpu.GPU_FilterEnum.GPU_FILTER_NEAREST);
			IntPtr target = SDL_gpu.GPU_LoadTarget(image);
			var rt = new RenderTarget(width, height)
			{
				ImagePtr = image,
				TargetPtr = target
			};
			return rt;
		}

		public static void DrawRenderTarget(RenderTarget target, int x, int y, int scaleX, int scaleY)
		{
			var rect = new SDL_gpu.GPU_Rect { x = 0, y = 0, w = target.Width, h = target.Height };
			SDL_gpu.GPU_BlitScale(target.ImagePtr, ref rect, MainScreen, x, y, scaleX, scaleY);
		}
		#endregion
	}
}
