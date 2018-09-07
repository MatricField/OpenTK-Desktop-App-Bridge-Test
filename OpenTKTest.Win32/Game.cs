using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTKTest.Win32
{
    public class Game
    {
        private GameWindow window;

        public string Title
        {
            get => window.Title;
            set => window.Title = value;
        }

        public Game(GameWindow window)
        {
            this.window = window;
            Start();
        }

        protected virtual void Start()
        {
            window.Load += Loaded;
            window.RenderFrame += RenderFrame;
            window.Resize += Resize;
            window.Run(60, 60);
        }

        protected virtual void RenderFrame(object sender, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(1, 1);
            GL.Vertex2(49, 1);
            GL.Vertex2(25, 49);
            GL.End();
            window.SwapBuffers();
        }

        protected virtual void Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, window.Height, window.Width);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, 50, 0, 50, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected virtual void Loaded(object sender, EventArgs e)
        {
            GL.ClearColor(0, 125, 170, 255);
        }
    }
}
