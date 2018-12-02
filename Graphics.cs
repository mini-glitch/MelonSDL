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

		public Image(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		public void Release()
		{
			if (Ptr != IntPtr.Zero)
			{
				SDL_gpu.GPU_FreeImage(Ptr);
				Ptr = IntPtr.Zero;
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

		public static IntPtr MainScreen { get; internal set; }

		#region Global state
		private static SDL.SDL_Color _backgroundColor;
		#endregion

		#region Color state
		public static void SetBackgroundColor(byte r, byte g, byte b)
		{
			_backgroundColor.r = r;
			_backgroundColor.g = g;
			_backgroundColor.b = b;
		}
		public static Color GetBackgroundColor() => new Color(_backgroundColor);
		#endregion

		#region Shapes
		public static void Pixel(float x, float y, Color color)
		{
			SDL_gpu.GPU_Pixel(MainScreen, x, y, color.ToSDLColor());
		}

		public static void Line(float x1, float y1, float x2, float y2, Color color)
		{
			SDL_gpu.GPU_Line(MainScreen, x1, y1, x2, y2, color.ToSDLColor());
		}

		public static void Circle(DrawMode mode, float x, float y, float radius, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Circle(MainScreen, x, y, radius, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_CircleFilled(MainScreen, x, y, radius, color.ToSDLColor()); break;
			}
		}

		public static void Arc(DrawMode mode, float x, float y, float radius, float start_angle, float end_angle, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Arc(MainScreen, x, y, radius, start_angle, end_angle, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_ArcFilled(MainScreen, x, y, radius, start_angle, end_angle, color.ToSDLColor()); break;
			}
		}

		public static void Ellipse(DrawMode mode, float x, float y, float rx, float ry, float degrees, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Ellipse(MainScreen, x, y, rx, ry, degrees, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_EllipseFilled(MainScreen, x, y, rx, ry, degrees, color.ToSDLColor()); break;
			}
		}

		public static void Sector(DrawMode mode, float x, float y, float inner_radius, float outer_radius, float start_angle, float end_angle, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Sector(MainScreen, x, y, inner_radius, outer_radius, start_angle, end_angle, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_SectorFilled(MainScreen, x, y, inner_radius, outer_radius, start_angle, end_angle, color.ToSDLColor()); break;
			}
		}

		public static void Triangle(DrawMode mode, float x1, float y1, float x2, float y2, float x3, float y3, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Tri(MainScreen, x1, y1, x2, y2, x3, y3, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_TriFilled(MainScreen, x1, y1, x2, y2, x3, y3, color.ToSDLColor()); break;
			}
		}

		public static void Rectangle(DrawMode mode, float x1, float y1, float x2, float y2, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Rectangle(MainScreen, x1, y1, x2, y2, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_RectangleFilled(MainScreen, x1, y1, x2, y2, color.ToSDLColor()); break;
			}
		}

		public static void RectangleRounded(DrawMode mode, float x1, float y1, float x2, float y2, float radius, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_RectangleRound(MainScreen, x1, y1, x2, y2, radius, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_RectangleRoundFilled(MainScreen, x1, y1, x2, y2, radius, color.ToSDLColor()); break;
			}
		}

		public static void Polygon(DrawMode mode, float[] vertices, Color color)
		{
			switch (mode)
			{
				case DrawMode.Line: SDL_gpu.GPU_Polygon(MainScreen, (uint)vertices.Length / 2, vertices, color.ToSDLColor()); break;
				case DrawMode.Fill: SDL_gpu.GPU_PolygonFilled(MainScreen, (uint)vertices.Length / 2, vertices, color.ToSDLColor()); break;
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

		public static void DrawImage(Image image, float x, float y)
		{
			var rect = new SDL_gpu.GPU_Rect { x = 0, y = 0, w = image.Width, h = image.Height };
			SDL_gpu.GPU_Blit(image.Ptr, ref rect, MainScreen, x, y);
		}
		
		public static void DrawImage(Image image, Rect rect, float x, float y)
		{
			var gpuRect = rect.ToGPURect();
			SDL_gpu.GPU_Blit(image.Ptr, ref gpuRect, MainScreen, x, y);
		}

		#endregion
	}
}
