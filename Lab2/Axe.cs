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

