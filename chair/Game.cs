using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace chair
{
    class Game
    {
        public GameWindow window;

        public Game(GameWindow windowInput)
        {
            this.window = windowInput;
            Start();
        }

        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0/60.0);
        }

        void resize(object obj, EventArgs args)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-80.0, 80.0, -80.0, 80.0, -1.0, 1.0);
            //GL.Ortho(0.0, 50.0, 0.0, 50.0, -1.0, 1.0);
            //Matrix4 matrix = Matrix4.Perspective(45.0f, window.Width / window.Height, 1.0f, 100.0f);
            //GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Color3(1.0,0.0,0.0);

            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex2(1.0, 1.0);
            //GL.Vertex2(49.0, 1.0);
            //GL.Vertex2(25.0, 49.0);
            //GL.End();

            //GL.Begin(PrimitiveType.Quads);
            //GL.Vertex2(30.0, 30.0);
            //GL.Vertex2(-30.0, 30.0);
            //GL.Vertex2(-30.0, -30.0);
            //GL.Vertex2(30.0, -30.0);

            //GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.54, 0.27, 0.07);
            //GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex2(-30.0, 50.0);     // +x, +y 
            GL.Vertex2(-40.0, 50.0);    // -x, +y
            GL.Vertex2(-40.0, -50.0);   // -x, -y
            GL.Vertex2(-30.0, -50.0);    // +x, -y
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.54, 0.27, 0.07);
            //GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex2(30.0, 0.0);     // +x, +y 
            GL.Vertex2(-30.0, 0.0);    // -x, +y
            GL.Vertex2(-30.0, -10.0);   // -x, -y
            GL.Vertex2(30.0, -10.0);    // +x, -y
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.54, 0.27, 0.07);
            //GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex2(30.0, 0.0);     // +x, +y 
            GL.Vertex2(20.0, 0.0);    // -x, +y
            GL.Vertex2(20.0, -50.0);   // -x, -y
            GL.Vertex2(30.0, -50.0);    // +x, -y
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.54, 0.27, 0.07);
            //GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex2(60.0, 20.0);     // +x, +y 
            GL.Vertex2(0.0, 20.0);    // -x, +y
            GL.Vertex2(-30.0, 0.0);   // -x, -y
            GL.Vertex2(30.0, 0.0);    // +x, -y
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.54, 0.27, 0.07);
            //GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex2(60.0, 20.0);     // +x, +y 
            GL.Vertex2(30.0, 0.0);    // -x, +y
            GL.Vertex2(30.0, -10.0);   // -x, -y
            GL.Vertex2(60.0, 10.0);    // +x, -y
            GL.End();

            window.SwapBuffers();
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }
}
