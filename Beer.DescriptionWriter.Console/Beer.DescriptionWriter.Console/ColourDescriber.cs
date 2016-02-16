namespace Beer.DescriptionWriter.Console
{
    class ColourDescriber
    {
        //http://www.beercolor.com/2008bjcpsrmbeercolordescrit.htm
        public static string DescribeColour(decimal SRM)
        {
            if (SRM > 40)
            {
                return "The beer has a dark opaque blackness; priest's socks black.";
            } 
            if (SRM > 35)
            {
                return "The beer is very dark almost black, but not as black as priest's socks.";
            }
            if (SRM > 30)
            {
                return "The beer is a very dark brown.";
            }
            if (SRM > 22)
            {
                return "The beer is not just Brown, it is Dark Brown.";
            }
             if (SRM > 19)
            {
                return "The beer is Brown, no more no less.";
            }
            if (SRM > 17)
            {
                return "The beer is light brown.";
            }
            if (SRM > 14)
            {
                return "The beer is copper coloured.";
            }
            if (SRM > 10)
            {
                return "The beer is a deep golden amber.";
            }
            if (SRM > 6)
            {
                return "The beer has an amber colour.";
            }
             if (SRM > 5)
            {
                return "The beer has the colour of dark straw.";
            }
            if (SRM > 3)
            {
                return "The beer is a medium yellow.";
            }
            if (SRM > 2)
            {
                return "The beer is the colour of straw.";
            }
            return "The beer's colour defies description, bordering on translucent.";
        }
    }
}
