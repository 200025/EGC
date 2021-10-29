    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenTK;
    using OpenTK.Graphics;
    using OpenTK.Graphics.OpenGL;
    using OpenTK.Input;



    namespace OpenTK_immediate_mode
    {
        class Axe
        {

            private bool ascunde;
            private int LungimeAxe;
            private Color culoareOx;
            private Color culoareOy;
            private Color CuloareOz;
            public Axe()
            {

                LungimeAxe = 75;
                culoareOx = Color.Red;
                culoareOy = Color.Yellow;
                CuloareOz = Color.Green;
            }
            public void Triunghi(int a,int b, int c)
            {
                if (ascunde == false)
                {
                    GL.Begin(PrimitiveType.Triangles);
                    GL.Color3(Color.Red);
                    GL.Vertex3(a, 0, 0);
                    GL.Vertex3(0, b, 0);
                    GL.Vertex3(0, 0, c);
                    GL.End();
                }
            }
            public void tabla(int a)
            {
                if (ascunde == false)
            {
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Red);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0, a, 0);
                GL.Vertex3(a, a, 0);
                GL.Vertex3(a, 0, 0);
                GL.End();
                
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Green);
                GL.Vertex3(a, 0, 0);
                GL.Vertex3(a, a, 0);
                GL.Vertex3(a, a, a);
                GL.Vertex3(a, 0, a);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Black);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(a, 0, 0);
                GL.Vertex3(a, 0, a);
                GL.Vertex3(0, 0, a);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Pink);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0, a, 0);
                GL.Vertex3(0, a, a);
                GL.Vertex3(0, 0, a);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Purple);
                GL.Vertex3(0, 0, a);
                GL.Vertex3(0, a, a);
                GL.Vertex3(a, a, a);
                GL.Vertex3(a, 0, a);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Orange);
                GL.Vertex3(a, a, a);
                GL.Vertex3(a, a, 0);
                GL.Vertex3(0, a, 0);
                GL.Vertex3(0, a, a);
                GL.End();
            }
            }

        public void cub(int x,int y,int z,int new_X, int new_Y, int new_Z)
        {
            if (ascunde == false)
            {
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Red);
                GL.Vertex3(new_X+0, new_Y+0, new_Z+0);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+ 0);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+0);
                GL.Vertex3(new_X + x, new_Y + 0, new_Z+0);
                GL.End();

                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Green);
                GL.Vertex3(new_X + x, new_Y + 0, new_Z+0);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+ 0);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+ z);
                GL.Vertex3(new_X + x, new_Y + 0, new_Z+z);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Black);
                GL.Vertex3(new_X + 0, new_Y + 0, new_Z+ 0);
                GL.Vertex3(new_X+x, new_Y + 0, new_Z + 0);
                GL.Vertex3(new_X+x, new_Y + 0, new_Z+ z);
                GL.Vertex3(new_X+0, new_Y + 0, new_Z+ z);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Pink);
                GL.Vertex3(new_X+0, new_Y + 0, new_Z+ 0);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+0);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+z);
                GL.Vertex3(new_X + 0, new_Y + 0, new_Z+z);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Purple);
                GL.Vertex3(new_X + 0, new_Y + 0, new_Z+ z);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+ z);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+z);
                GL.Vertex3(new_X + x, new_Y + 0, new_Z+z);
                GL.End();
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Color.Orange);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+z);
                GL.Vertex3(new_X + x, new_Y + y, new_Z+ 0);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+ 0);
                GL.Vertex3(new_X + 0, new_Y + y, new_Z+ z);
                GL.End();
            }
        }
        public void Setafiseaza()
            {
                ascunde = false;
            }
            public void Setascunde()
            {
                ascunde = true;
            }

        }
    }

