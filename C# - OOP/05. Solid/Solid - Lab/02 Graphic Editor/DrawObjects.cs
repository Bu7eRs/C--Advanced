using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class DrawObjects
    {
	    private readonly IShape shape;
	    public DrawObjects(IShape shape)
	    {
		    this.shape = shape;
	    }
        public string DrawShape()
        {
	        return this.shape.Draw();
        }
    }
}
