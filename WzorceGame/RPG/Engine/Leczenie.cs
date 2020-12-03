using System;
using System.Collections.Generic;
using System.Text;


namespace Engine
{
    public class Leczenie
    {
        public static bool CzyUleczyc(PostacGracza postac)
        {
            if ((postac.Aktual_Hp < (0.50 * postac.Hp)))
            {
                postac.Aktual_Hp = postac.Aktual_Hp + 20;
                if (postac.Aktual_Hp > 100)
                {
                    postac.Aktual_Hp = 100;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
        
              
}

