using System;
using SDL2;

namespace Melon
{
    public abstract class Melon
    {
		protected abstract void Load();
		protected abstract void Unload();
		protected abstract void Update(float deltaTime);
		protected abstract void Draw();

		public void Run()
		{
			SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING);
			IntPtr screen = SDL_gpu.GPU_Init(640, 360, 0);

			Graphics.MainScreen = screen;

			Load();

			ulong timerNow = SDL.SDL_GetPerformanceCounter();
			ulong timerLast = 0;
			float timerDelta = 0f;
			float timerFixedDelta = 1f / 60f;
			float timerAccumulator = 0f;

			bool isRunning = true;
			while (isRunning)
			{
				// Handle events
				while (SDL.SDL_PollEvent(out SDL.SDL_Event ev) != 0)
				{
					if (ev.type == SDL.SDL_EventType.SDL_KEYDOWN && ev.key.keysym.sym == SDL.SDL_Keycode.SDLK_ESCAPE)
					{
						isRunning = false;
					}
					if (ev.type == SDL.SDL_EventType.SDL_QUIT)
					{
						isRunning = false;
					}
				}

				timerLast = timerNow;
				timerNow = SDL.SDL_GetPerformanceCounter();
				timerDelta = (timerNow - timerLast) / (float)SDL.SDL_GetPerformanceFrequency();

				timerAccumulator += timerDelta;
				while (timerAccumulator >= timerFixedDelta)
				{
					Update(timerFixedDelta);
					timerAccumulator -= timerFixedDelta;
				}

				var bgColor = Graphics.GetBackgroundColor();
				SDL_gpu.GPU_ClearRGB(screen, bgColor.r, bgColor.g, bgColor.b);
				Draw();
				SDL_gpu.GPU_Flip(screen);
				SDL.SDL_Delay(1);
			}

			Unload();

			SDL_gpu.GPU_Quit();
		}
    }
}
