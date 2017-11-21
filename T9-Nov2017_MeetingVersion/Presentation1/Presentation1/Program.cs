using System;

namespace Test1
{
    public static class Global
    {
        //1. first global para for number of geo shape
        private static int aa;
        public static int NOP
        {
            get
            {
                Console.WriteLine("Step1: Footing Shape Input "); 
                //Console.WriteLine(" "); 
                Console.Write("Number of Points on the footing boundary: ");
                return aa = int.Parse(Console.ReadLine());
            }
        }

        //1.1 Refer the Global.NOP
        private static int NOP_value;
        public static int NOPNOP
        {
            get
            {
                NOP_value = aa;
                return NOP_value;
            }
        }

        //2. input global x and y coordinate based on NOP numbers.
        ////2.1 x-input
        private static double[] x_global;
        private static double[] yy_global;
        public static double[] XXX_g   ///transfer step
        {
            get
            {
                int number = Global.NOPNOP;
                x_global = new double[number];
                yy_global = new double[number];
                Console.WriteLine("Step5: Geometry Info Input "); 

                for (int i = 0; i < number; i++)
                {
                    
                    Console.Write("Input the " + (i + 1) + " x value in Global: ");
                    x_global[i] = double.Parse(Console.ReadLine());
                    //
                    Console.Write("Input the " + (i + 1) + " y value in Global: ");
                    yy_global[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                }
                return x_global;
            }
        }
        ////2.2 y-input
        private static double[] y_global;
        public static double[] YYY_g   ///transfer step
        {
            get
            {
                y_global = yy_global;
                return y_global;
            }
        }

        //3. transfer the x, y values, since the second reference in the following codes.
        private static double[] x_value;
        public static double[] X_global
        {
            get
            {
                x_value = x_global;
                return x_value;
            }
        }
        //
        private static double[] y_value;
        public static double[] Y_global
        {
            get
            {
                y_value = y_global;
                return y_value;
            }
        }

        //4. Soil Distribution Type
        private static int soiltype;
        public static int soilchoose
        {
            get
            {
                Console.Write("The soil distribution type is: ");
                return soiltype = int.Parse(Console.ReadLine());
            }
        }
        //4.1 transfer the soil type
        private static int soil2;
        public static int soilsoil
        {
            get
            {
                soil2 = soiltype;
                return soil2;
            }
        }
         
        //5. input the number of openings
        private static int aaa;
        public static int Op_Num
        {

            get
            {
                Console.WriteLine(" "); 
                Console.WriteLine("Step7: Openings Info Input");
                //Console.WriteLine(" "); 
                Console.Write("The Number of Openings is: ");
                return aaa = int.Parse(Console.ReadLine());

            }
        }
        //5.1 Refer the Global.Op_Num
        private static int Op_value;
        public static int Op_NumNum
        {
            get
            {
                Op_value = aaa;
                return Op_value;
            }
        }
        //5.2 Refer the Global.Op_Num
        private static int OpOp_value;
        public static int Op_NumNumNum
        {
            get
            {
                OpOp_value = Op_value;
                return OpOp_value;
            }
        }

        //6. Input the shape of all the openings (1 for circle, 2 for polygon)
        private static int[] shapeshape;
        public static int[] shape_Op
        {
            get
            {
                shapeshape = new int[Global.Op_Num];
                for (int j = 0; j < Global.Op_NumNum; j++)
                {
                    Console.Write("Input the shape of the " + (j + 1) + "  opening: (1 for circle, 2 for polygon): ");
                    shapeshape[j] = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------------------------------- ");
                    if (shapeshape[j] == 1)
                    {
                        Console.WriteLine("The shape of the " + (j + 1) + "  opening is circle");
                        Console.WriteLine(" ");
                    }
                    //Console.WriteLine(" ");
                    if (shapeshape[j] == 2)
                    {
                        Console.WriteLine("The shape of the " + (j + 1) + "  opening is polygon");
                        Console.WriteLine(" ");
                    }

                }
                return shapeshape;
            }
        }
        //6.1
        private static int[] shapeshape2;
        public static int[] shape_OpOp
        {
            get
            {
                shapeshape2 = shapeshape;
                return shapeshape2;
            }
        }

        //7. Input the coords for circle openings (radius,x,y)
        private static Double[] openingcircle;
        public static double[] op_circle
        {
            get
            {
                openingcircle = new double[3];
                //Console.WriteLine("--------Input the info for the circle opening in the form of: radius, x_center_global, y_center_global------- ");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Input the radius for the circle: ");
                openingcircle[0] = double.Parse(Console.ReadLine());
                //Console.WriteLine(" ");
                Console.Write("Input the x value for the circle center in Global: ");
                openingcircle[1] = double.Parse(Console.ReadLine());
                Console.Write("Input the y value for the circle center in Global: ");
                openingcircle[2] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                return openingcircle;
            }
        }
        //7.1
        private static double[] openingcircle1;
        public static double[] op_circlecircle
        {
            get
            {
                openingcircle1 = openingcircle;
                return openingcircle1;
            }
        }


        //8. Input the poly shape corner numbers (clockwise)
        private static int bbb;
        public static int poly_NOP
        {
            get
            {
                Console.Write("Input the number of poly opening corners: ");
                return bbb = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
        }

        //8.1 Refer the Global.poly_NOP
        private static int poly_NOP_value;
        public static int poly_NOPNOP
        {
            get
            {
                poly_NOP_value = bbb;
                return poly_NOP_value;
            }
        }
        //8.2 Refer the Global.poly_NOP
        private static int poly_NOPNOP_value;
        public static int poly_NOPNOPNOP
        {
            get
            {
                poly_NOPNOP_value = poly_NOP_value;
                return poly_NOPNOP_value;
            }
        }

        //9. Input the x-coords for Polygon openings (x)

        private static double[] openingpoly_x;
        private static double[] openingpoly_y;
        public static double[] x_poly
        {
            get
            {
                int number = Global.poly_NOPNOP;
                openingpoly_x = new double[number];
                openingpoly_y = new double[number];
                Console.WriteLine("The input sequence should be in counter-clockwise order for all the points");
                for (int j = 0; j < number; j++)
                {
                    Console.Write("Input the {0} points' x coordinate in global:", (j + 1));
                    openingpoly_x[j] = double.Parse(Console.ReadLine());

                    Console.Write("Input the {0} points' y coordinate in global:", (j + 1));
                    openingpoly_y[j] = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                }
                return openingpoly_x;
            }
        }

        //9.1
        private static double[] openingpoly_x1;
        private static double[] openingpoly_y1;
        public static double[] x_polypoly
        {
            get
            {
                openingpoly_x1 = openingpoly_x;
                openingpoly_y1 = openingpoly_y;
                return openingpoly_x1;
            }
        }

        //10. Input the y-coords for Polygon openings (x)

        private static double[] openingpoly_yy;
        public static double[] y_poly
        {
            get
            {
                openingpoly_yy = openingpoly_y;
                return openingpoly_yy;
            }
        }

        //10.1
        private static double[] openingpoly_yyy;
        public static double[] y_polypoly
        {
            get
            {
                openingpoly_yyy = openingpoly_y1;
                return openingpoly_yyy;
            }
        }
        //11. Input the y-coords for Polygon openings (y)
        private static double[] delta_1 = new double[3];
        public static double[] delta_iter1
        {
            get
            {
                Console.Write("The increments of delta_A is:  ");
                delta_1[0] = double.Parse(Console.ReadLine());
                //Console.WriteLine(" ");

                Console.Write("The increments of delta_b is:  ");
                delta_1[1] = double.Parse(Console.ReadLine());
                //Console.WriteLine(" ");

                Console.Write("The increments of delta_q0 is:  ");
                delta_1[2] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                return delta_1;
            }
        }

        //10.1 Refer the increments
        private static double[] delta_2;
        public static double[] delta_iter2
        {
            get
            {
                delta_2 = delta_1;
                return delta_2;
            }
        }

    }

    /// //////////////////////////////////////////////////////////////

    class Program
    {
        //Calling boundary x coord
        static double Tim1(int x)
        {
            double A = Global.XXX_g[x];
            return A;
        }
        //Calling boundary y coord
        static double Tim2(int x)
        {
            double A = Global.YYY_g[x];
            return A;
        }
        //calculate determinant
        static double det(double a, double b, double c, double d, double e, double f, double g, double h, double i)
        {
            double[,] arr = { { a, b, c }, { d, e, f }, { g, h, i } };
            double det_of_arr = arr[0, 0] * (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1]) -
                                arr[0, 1] * (arr[1, 0] * arr[2, 2] - arr[1, 2] * arr[2, 0]) +
                                arr[0, 2] * (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]);
            return det_of_arr;
        }

        //main program
        static double Tim1_P(double slope, double b, double q0_soil)
        {
            //download the global value

            double[] xx_g = new double[Global.NOPNOP];
            double[] yy_g = new double[Global.NOPNOP];
            xx_g[0] = Tim1(0);//maybe every iteration you need to input once
            yy_g[0] = Tim2(0);

            for (int j = 1; j < Global.NOPNOP; j++)
            {
                xx_g[j] = Global.X_global[j];
                yy_g[j] = Global.Y_global[j];
            }


            double ROT;//The fixed Neutral Axis angle for now

            ROT = Math.Atan(slope) * (180 / Math.PI);//-90~90
            Console.WriteLine("In this step, the Neutral Axis Angle is {0}.", ROT);
            Console.WriteLine(" ");
            double radians_ROT = ROT * (Math.PI / 180);
            //double slope_ROT = Math.Tan(radians_ROT);//slope for the neutral axis in global
            double sine = Math.Sin(-radians_ROT);//sine of local， inverse transform
            double cos = Math.Cos(-radians_ROT);//cosine of local

            //double b;//y-intercept
            //Console.Write("Y-Intercept is: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("The function of Neutral Axis in Global is y = {0}x+ {1}", slope_ROT, b);
            //Console.WriteLine(" ");//return

            //double q0_soil;
            //Console.Write("Input the soil bering pressure value q0: ");// soil bearing pressure
            //q0_soil = double.Parse(Console.ReadLine());
            //Console.WriteLine(" ");//return    

            //local gloabl transfer     
            double[] xx_l = new double[Global.NOPNOP];//points x coordinates in local, with x-y in original point
            double[] yy_l = new double[Global.NOPNOP];//points y coordinates in local, with x-y in original point    

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_l[j] = cos * xx_g[j] - sine * yy_g[j];//x global-->local, original point at O(0,0)
                yy_l[j] = sine * xx_g[j] + cos * yy_g[j];//y global-->local, original point at O(0,0)
            }

            double bb_l;
            bb_l = cos * b;
            double y_max = Math.Abs(yy_l[0] - bb_l);
            double x_check = xx_l[0];

            for (int k = 0; k < xx_g.Length; k++)
            {
                if (Math.Abs(yy_l[k] - bb_l) > y_max)
                {
                    if (yy_l[k] > 0)
                    {
                        y_max = Math.Abs(yy_l[k] - bb_l);
                        x_check = xx_l[k];
                    }
                }
            }

            for (int jj = 0; jj < xx_g.Length; jj++) //get final x,y in local --for a certain geometry shape and a certain N.A
            {
                xx_l[jj] = Math.Round(xx_l[jj] - x_check, 3);
                yy_l[jj] = Math.Round(yy_l[jj] - cos * b, 3);
            }

            double[] k_l = new double[xx_l.Length];//slope for each line segment in global coordinate
            double[] b_l = new double[xx_l.Length];//slope for each line segment in global coordinate

            for (int ii = 0; ii < (xx_l.Length - 1); ii++)//slope
            {
                k_l[ii] = Math.Round((yy_l[ii + 1] - yy_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                b_l[ii] = Math.Round((yy_l[ii] * xx_l[ii + 1] - yy_l[ii + 1] * xx_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", ii + 1, k_l[ii], b_l[ii], xx_l[ii], xx_l[ii + 1]);//return
            }

            //last point's slope//
            int tt = Global.NOPNOP - 1;
            k_l[tt] = Math.Round((yy_l[tt] - yy_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            b_l[tt] = Math.Round((yy_l[0] * xx_l[tt] - yy_l[tt] * xx_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", Global.NOPNOP, k_l[tt], b_l[tt], xx_l[tt], xx_l[0]);//return
            Console.WriteLine(" ");//return、、
            //local coordinates are created, ax+b for each segment is defined// 

            ///////////////////////////soil bearing pressure///////////////////////////////////
            ///////A. exterior boundary ////////////

            double[] P_l = new double[xx_l.Length];
            double[] Mx_l = new double[xx_l.Length];
            double[] My_l = new double[xx_l.Length];


            Console.WriteLine("Step6: Input the Distribution type of the soil bearing pressure.");
            Console.WriteLine("------------(1. Uniformly, 2. Linearly, 3. Parabolic)-----------");
            //Console.WriteLine(" ");

            //Console.Write("The distribution type: ");
            double soiltypevalue = Global.soilchoose;//initiate the choice
            double Distribute_soil = Global.soilsoil;//transfer the value


            /////////////////////////////////////////////uniformly/////////////////////////////////////////
            if (Distribute_soil == 1)
            {

                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }
                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));

                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }
                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary uniform distribution P,Mx,My are calculated//
            /////////////////////////////////////////////////////Linearly///////////////////////////////////////////////////////////////
            else if (Distribute_soil == 2)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary linear distribution P,Mx,My are calculated//
            //////////////////////////////////////////////////////////////Parabolic//////////////////////////////////////////////////////
            else if (Distribute_soil == 3)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary parabolic distribution P,Mx,My are calculated//

            double P_sum = 0;
            double Mx_sum = 0;
            double My_sum = 0;
            for (int kk = 0; kk < (xx_l.Length); kk++)
            {
                P_sum += P_l[kk];
                Mx_sum += Mx_l[kk];
                My_sum += My_l[kk];
            }
            //Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------"); 
            Console.WriteLine("--Footing Loading Status w/o opening & cutting--");
            Console.WriteLine("Axial Force P Sum is " + P_sum);
            Console.WriteLine("Moment about x axis (Mx) is " + Mx_sum);
            Console.WriteLine("Moment about y axis (My) is " + My_sum);
            Console.WriteLine("------------------------------------------------");
            //Console.WriteLine(" ");
            ///////B. input interior opening////////
            int[] openingshape = Global.shape_Op;
            int numberT3 = Global.Op_NumNum;
            double[] P_open = new double[numberT3];
            double[] Mx_open = new double[numberT3];
            double[] My_open = new double[numberT3];


            for (int i = 0; i < numberT3; i++)
            {
                //////// circle ////////
                if (openingshape[i] == 1)
                {
                    double[] cirinfo = new double[3];
                    cirinfo = Global.op_circle;

                    double theta_deg = 22.5; // 360/16 degree
                    int noc = (int)(360 / theta_deg);//number of circle points

                    double[] xx_cir = new double[noc];
                    double[] yy_cir = new double[noc];
                    double rr_circle = cirinfo[0];
                    double xx_cir_centgl = cirinfo[1];
                    double yy_cir_centgl = cirinfo[2];

                    double xx_cir_centloc = cos * xx_cir_centgl - sine * yy_cir_centgl - x_check; //circle center in local
                    double yy_cir_centloc = sine * xx_cir_centgl + cos * yy_cir_centgl - cos * b;  //circle center in local

                    for (int j = 0; j < xx_cir.Length; j++) //get cir points' x,y in local
                    {
                        double theta_cir = theta_deg * (j) * (Math.PI / 180);//counterclockwise
                        xx_cir[j] = Math.Round(xx_cir_centloc - rr_circle * Math.Sin(theta_cir), 3);
                        yy_cir[j] = Math.Round(yy_cir_centloc + rr_circle * Math.Cos(theta_cir), 3);
                    }

                    //circle exterior boundaries' slopes//
                    double[] k_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate
                    double[] b_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate

                    for (int ii = 0; ii < (xx_cir.Length - 1); ii++)//slope
                    {
                        k_cir[ii] = Math.Round((yy_cir[ii + 1] - yy_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                        b_cir[ii] = Math.Round((yy_cir[ii] * xx_cir[ii + 1] - yy_cir[ii + 1] * xx_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                    }
                    //last point's slope//
                    k_cir[noc - 1] = Math.Round((yy_cir[noc - 1] - yy_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);
                    b_cir[noc - 1] = Math.Round((yy_cir[0] * xx_cir[noc - 1] - yy_cir[noc - 1] * xx_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_cir = new double[xx_cir.Length];
                    double[] Mx_cir = new double[xx_cir.Length];
                    double[] My_cir = new double[xx_cir.Length];

                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));

                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }

                    }
                    // interior circle opening uniform distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));

                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening parabolic distribution P,Mx,My are calculated//

                    //////////////////sum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (noc); kkk++)
                    {
                        P_open[i] += P_cir[kkk];
                        Mx_open[i] += Mx_cir[kkk];
                        My_open[i] += My_cir[kkk];
                    }

                    //Console.WriteLine(" ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("----Load Lost of the {0} Opening-----", (i + 1));
                    Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }

                /////////////////////////// poly //////////////////////////////////////////////////

                if (openingshape[i] == 2)
                {
                    int poly1 = Global.poly_NOP;
                    int poly = Global.poly_NOPNOP;
                    double[] poly_x_info = new double[poly];
                    double[] poly_y_info = new double[poly];
                    poly_x_info = Global.x_poly;
                    poly_y_info = Global.y_poly;

                    //double[] theta_cir = new double[noc];
                    double[] xx_g_pol = new double[poly];
                    double[] yy_g_pol = new double[poly];
                    for (int iii = 0; iii < poly; iii++)
                    {
                        //Console.Write("Input the {0} points' x coordinate in global:", (iii + 1));
                        xx_g_pol[iii] = poly_x_info[iii];
                        //Console.Write("Input the {0} points' y coordinate in global:", (iii + 1));
                        yy_g_pol[iii] = poly_y_info[iii];
                        //Console.WriteLine(" ");
                    }


                    //local gloabl transfer     
                    double[] xx_pol = new double[poly];//points x coordinates in local, with x-y in original point
                    double[] yy_pol = new double[poly];//points y coordinates in local, with x-y in original point    

                    for (int j = 0; j < poly; j++)
                    {
                        xx_pol[j] = cos * xx_g_pol[j] - sine * yy_g_pol[j] - x_check;//x global-->local, original point at O(0,0)
                        yy_pol[j] = sine * xx_g_pol[j] + cos * yy_g_pol[j] - cos * b;//y global-->local, original point at O(0,0)
                    }
                    //exterior boundaries' slopes//
                    double[] k_pol = new double[poly];//slope for each line segment in local coordinate
                    double[] b_pol = new double[poly];//slope for each line segment in local coordinate

                    for (int ii = 0; ii < (poly - 1); ii++)//slope
                    {
                        k_pol[ii] = Math.Round((yy_pol[ii + 1] - yy_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                        b_pol[ii] = Math.Round((yy_pol[ii] * xx_pol[ii + 1] - yy_pol[ii + 1] * xx_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                    }
                    //last point's slope//
                    k_pol[poly - 1] = Math.Round((yy_pol[poly - 1] - yy_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    b_pol[poly - 1] = Math.Round((yy_pol[0] * xx_pol[poly - 1] - yy_pol[poly - 1] * xx_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    // Geometry input for the polygon//

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_pol = new double[poly];
                    double[] Mx_pol = new double[poly];
                    double[] My_pol = new double[poly];
                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (poly - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));

                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }

                    }
                    // interior polygon opening uniform distribution P,Mx,My are calculated//

                ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));

                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening parabolic distribution P,Mx,My are calculated//

                    //////////////////ttsum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (poly); kkk++)
                    {
                        P_open[i] += P_pol[kkk];
                        Mx_open[i] += Mx_pol[kkk];
                        My_open[i] += My_pol[kkk];
                    }

                    // Console.WriteLine(" ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("----Load Lost of the {0} Opening-----",(i + 1));
                    Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    Console.WriteLine("-------------------------------------");
                    // Console.WriteLine(" ");
                }
            }

            //////sum of the P, Mx and My/////
            double P_open_sum = 0;
            double Mx_open_sum = 0;
            double My_open_sum = 0;
            for (int i = 0; i < P_open.Length; i++)
            {
                P_open_sum += P_open[i];
                Mx_open_sum += Mx_open[i];
                My_open_sum += My_open[i];
            }

            /////////sum of all the parts////////
            double PP = P_sum + P_open_sum;
            double MxMx = Mx_sum + Mx_open_sum;
            double MyMy = My_sum + My_open_sum;
            Console.WriteLine("------------------------------------------------------------"); 
            Console.WriteLine("-------Total Loading Status with openings and cuttings-------");
            Console.WriteLine("Total Axial Force is {0}", PP);
            Console.WriteLine("Total Moment about x axis (Mx) is {0}", MxMx);
            Console.WriteLine("Total Moment about y axis (My) is {0}", MyMy);
            Console.WriteLine("------------------------------------------------------------");
            return PP;
        }


        ////////////////////////////////////////////////////////////////////////

        static double F(double slope, double b, double q0_soil)
        {
            //download the global value

            double[] xx_g = new double[Global.NOPNOP];
            double[] yy_g = new double[Global.NOPNOP];


            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_g[j] = Global.X_global[j];
                yy_g[j] = Global.Y_global[j];
            }


            double ROT;//The fixed Neutral Axis angle for now

            ROT = Math.Atan(slope) * (180 / Math.PI);//-90~90
            double radians_ROT = ROT * (Math.PI / 180);
            double sine = Math.Sin(-radians_ROT);//sine of local， inverse transform
            double cos = Math.Cos(-radians_ROT);//cosine of local

            //local gloabl transfer     
            double[] xx_l = new double[Global.NOPNOP];//points x coordinates in local, with x-y in original point
            double[] yy_l = new double[Global.NOPNOP];//points y coordinates in local, with x-y in original point    

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_l[j] = cos * xx_g[j] - sine * yy_g[j];//x global-->local, original point at O(0,0)
                yy_l[j] = sine * xx_g[j] + cos * yy_g[j];//y global-->local, original point at O(0,0)
            }

            double bb_l;
            bb_l = cos * b;
            double y_max = Math.Abs(yy_l[0] - bb_l);
            double x_check = xx_l[0];

            for (int k = 0; k < xx_g.Length; k++)
            {
                if (Math.Abs(yy_l[k] - bb_l) > y_max)
                {
                    if (yy_l[k] > 0)
                    {
                        y_max = Math.Abs(yy_l[k] - bb_l);
                        x_check = xx_l[k];
                    }
                }
            }

            for (int jj = 0; jj < xx_g.Length; jj++) //get final x,y in local --for a certain geometry shape and a certain N.A
            {
                xx_l[jj] = Math.Round(xx_l[jj] - x_check, 3);
                yy_l[jj] = Math.Round(yy_l[jj] - cos * b, 3);
            }

            double[] k_l = new double[xx_l.Length];//slope for each line segment in global coordinate
            double[] b_l = new double[xx_l.Length];//slope for each line segment in global coordinate

            for (int ii = 0; ii < (xx_l.Length - 1); ii++)//slope
            {
                k_l[ii] = Math.Round((yy_l[ii + 1] - yy_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                b_l[ii] = Math.Round((yy_l[ii] * xx_l[ii + 1] - yy_l[ii + 1] * xx_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", ii + 1, k_l[ii], b_l[ii], xx_l[ii], xx_l[ii + 1]);//return
            }

            //last point's slope//
            int tt = Global.NOPNOP - 1;
            k_l[tt] = Math.Round((yy_l[tt] - yy_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            b_l[tt] = Math.Round((yy_l[0] * xx_l[tt] - yy_l[tt] * xx_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", Global.NOPNOP, k_l[tt], b_l[tt], xx_l[tt], xx_l[0]);//return
            //Console.WriteLine(" ");//return、、
            //local coordinates are created, ax+b for each segment is defined// 

            ///////////////////////////soil bearing pressure///////////////////////////////////
            ///////A. exterior boundary ////////////

            double[] P_l = new double[xx_l.Length];
            double[] Mx_l = new double[xx_l.Length];
            double[] My_l = new double[xx_l.Length];

            //Console.WriteLine("Input the Distribution type of the soil bering pressure.");
            //Console.WriteLine("--------(1. Uniformly, 2. Linearly, 3. Parabolic)------- ");
            //Console.WriteLine(" ");

            //Console.Write("The distribution type: ");
            //double soiltypevalue = Global.soilchoose;//initiate the choice
            double Distribute_soil = Global.soilsoil;//transfer the value


            /////////////////////////////////////////////uniformly/////////////////////////////////////////
            if (Distribute_soil == 1)
            {

                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }
                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));

                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }
                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary uniform distribution P,Mx,My are calculated//

           /////////////////////////////////////////////////////Linearly///////////////////////////////////////////////////////////////
            else if (Distribute_soil == 2)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        //My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] *(Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) * (3 * k_l[kk] * rr - b_l[kk]));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary linear distribution P,Mx,My are calculated//

            //////////////////////////////////////////////////////////////Parabolic//////////////////////////////////////////////////////
            else if (Distribute_soil == 3)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary parabolic distribution P,Mx,My are calculated//

            double P_sum = 0;
            double Mx_sum = 0;
            double My_sum = 0;
            for (int kk = 0; kk < (xx_l.Length); kk++)
            {
                P_sum += P_l[kk];
                Mx_sum += Mx_l[kk];
                My_sum += My_l[kk];
            }
            //Console.WriteLine(" ");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Axial Force P Sum is " + P_sum);
            //Console.WriteLine("Mx Sum is " + Mx_sum);
            //Console.WriteLine("My Sum is " + My_sum);
            // Console.WriteLine("-------------------------------------");

            //Console.WriteLine(" ");



            ///////B. input interior opening////////
            int[] openingshape = Global.shape_OpOp;
            int numberT3 = Global.Op_NumNumNum;

            double[] P_open = new double[numberT3];
            double[] Mx_open = new double[numberT3];
            double[] My_open = new double[numberT3];


            for (int i = 0; i < numberT3; i++)
            {
                //////// circle ////////
                if (openingshape[i] == 1)
                {
                    double[] cirinfo = new double[3];
                    cirinfo = Global.op_circlecircle;

                    double theta_deg = 22.5; // 360/16 degree
                    int noc = (int)(360 / theta_deg);//number of circle points

                    double[] xx_cir = new double[noc];
                    double[] yy_cir = new double[noc];
                    double rr_circle = cirinfo[0];
                    double xx_cir_centgl = cirinfo[1];
                    double yy_cir_centgl = cirinfo[2];

                    double xx_cir_centloc = cos * xx_cir_centgl - sine * yy_cir_centgl - x_check; //circle center in local
                    double yy_cir_centloc = sine * xx_cir_centgl + cos * yy_cir_centgl - cos * b;  //circle center in local

                    for (int j = 0; j < xx_cir.Length; j++) //get cir points' x,y in local
                    {
                        double theta_cir = theta_deg * (j) * (Math.PI / 180);//counterclockwise
                        xx_cir[j] = Math.Round(xx_cir_centloc - rr_circle * Math.Sin(theta_cir), 3);
                        yy_cir[j] = Math.Round(yy_cir_centloc + rr_circle * Math.Cos(theta_cir), 3);
                    }

                    //circle exterior boundaries' slopes//
                    double[] k_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate
                    double[] b_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate

                    for (int ii = 0; ii < (xx_cir.Length - 1); ii++)//slope
                    {
                        k_cir[ii] = Math.Round((yy_cir[ii + 1] - yy_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                        b_cir[ii] = Math.Round((yy_cir[ii] * xx_cir[ii + 1] - yy_cir[ii + 1] * xx_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                    }
                    //last point's slope//
                    k_cir[noc - 1] = Math.Round((yy_cir[noc - 1] - yy_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);
                    b_cir[noc - 1] = Math.Round((yy_cir[0] * xx_cir[noc - 1] - yy_cir[noc - 1] * xx_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_cir = new double[xx_cir.Length];
                    double[] Mx_cir = new double[xx_cir.Length];
                    double[] My_cir = new double[xx_cir.Length];

                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));

                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }

                    }
                    // interior circle opening uniform distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));

                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening parabolic distribution P,Mx,My are calculated//

                    //////////////////sum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (noc); kkk++)
                    {
                        P_open[i] += P_cir[kkk];
                        Mx_open[i] += Mx_cir[kkk];
                        My_open[i] += My_cir[kkk];
                    }

                    // Console.WriteLine(" ");
                    // Console.WriteLine("-------------------------------------");
                    // Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    // Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    // Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    // Console.WriteLine("-------------------------------------");
                    // Console.WriteLine(" ");
                }

                /////////////////////////// poly //////////////////////////////////////////////////

                if (openingshape[i] == 2)
                {
                    //int poly1 = Global.poly_NOP;
                    int poly = Global.poly_NOPNOPNOP;
                    double[] poly_x_info = new double[poly];
                    double[] poly_y_info = new double[poly];
                    poly_x_info = Global.x_polypoly;
                    poly_y_info = Global.y_polypoly;

                    //double[] theta_cir = new double[noc];
                    double[] xx_g_pol = new double[poly];
                    double[] yy_g_pol = new double[poly];
                    for (int iii = 0; iii < poly; iii++)
                    {
                        //Console.Write("Input the {0} points' x coordinate in global:", (iii + 1));
                        xx_g_pol[iii] = poly_x_info[iii];
                        //Console.Write("Input the {0} points' y coordinate in global:", (iii + 1));
                        yy_g_pol[iii] = poly_y_info[iii];
                        //Console.WriteLine(" ");
                    }


                    //local gloabl transfer     
                    double[] xx_pol = new double[poly];//points x coordinates in local, with x-y in original point
                    double[] yy_pol = new double[poly];//points y coordinates in local, with x-y in original point    

                    for (int j = 0; j < poly; j++)
                    {
                        xx_pol[j] = cos * xx_g_pol[j] - sine * yy_g_pol[j] - x_check;//x global-->local, original point at O(0,0)
                        yy_pol[j] = sine * xx_g_pol[j] + cos * yy_g_pol[j] - cos * b;//y global-->local, original point at O(0,0)
                    }
                    //exterior boundaries' slopes//
                    double[] k_pol = new double[poly];//slope for each line segment in local coordinate
                    double[] b_pol = new double[poly];//slope for each line segment in local coordinate

                    for (int ii = 0; ii < (poly - 1); ii++)//slope
                    {
                        k_pol[ii] = Math.Round((yy_pol[ii + 1] - yy_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                        b_pol[ii] = Math.Round((yy_pol[ii] * xx_pol[ii + 1] - yy_pol[ii + 1] * xx_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                    }
                    //last point's slope//
                    k_pol[poly - 1] = Math.Round((yy_pol[poly - 1] - yy_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    b_pol[poly - 1] = Math.Round((yy_pol[0] * xx_pol[poly - 1] - yy_pol[poly - 1] * xx_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    // Geometry input for the polygon//

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_pol = new double[poly];
                    double[] Mx_pol = new double[poly];
                    double[] My_pol = new double[poly];
                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (poly - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));

                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }

                    }
                    // interior polygon opening uniform distribution P,Mx,My are calculated//

                ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));

                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening parabolic distribution P,Mx,My are calculated//

                    //////////////////ttsum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (poly); kkk++)
                    {
                        P_open[i] += P_pol[kkk];
                        Mx_open[i] += Mx_pol[kkk];
                        My_open[i] += My_pol[kkk];
                    }

                    //Console.WriteLine(" ");
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    //Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    //Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }
            }

            //////sum of the P, Mx and My/////
            double P_open_sum = 0;
            double Mx_open_sum = 0;
            double My_open_sum = 0;
            for (int i = 0; i < P_open.Length; i++)
            {
                P_open_sum += P_open[i];
                Mx_open_sum += Mx_open[i];
                My_open_sum += My_open[i];
            }

            /////////sum of all the parts////////
            double PP = P_sum + P_open_sum;
            double MxMx = Mx_sum + Mx_open_sum;
            double MyMy = My_sum + My_open_sum;
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Total Axial Force is {0}", PP);
            //Console.WriteLine("Total Moment about x axis (Mx) is {0}", MxMx);
            //Console.WriteLine("Total Moment about y axis (My) is {0}", MyMy);
            //Console.WriteLine("-------------------------------------");

            return PP;
        }
        //////////////////////////////////////////////////////////////////////
        static double G(double slope, double b, double q0_soil)
        {
            //download the global value

            double[] xx_g = new double[Global.NOPNOP];
            double[] yy_g = new double[Global.NOPNOP];
            //xx_g[0] = Tim1(0);//maybe every iteration you need to input once
            //yy_g[0] = Tim2(0);

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_g[j] = Global.X_global[j];
                yy_g[j] = Global.Y_global[j];
            }


            double ROT;//The fixed Neutral Axis angle for now

            ROT = Math.Atan(slope) * (180 / Math.PI);//-90~90
            //Console.WriteLine("In this step, the Neutral Axis Angle is {0}.", ROT);
            //Console.WriteLine(" ");
            double radians_ROT = ROT * (Math.PI / 180);
            //double slope_ROT = Math.Tan(radians_ROT);//slope for the neutral axis in global
            double sine = Math.Sin(-radians_ROT);//sine of local， inverse transform
            double cos = Math.Cos(-radians_ROT);//cosine of local

            //double b;//y-intercept
            //Console.Write("Y-Intercept is: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("The function of Neutral Axis in Global is y = {0}x+ {1}", slope_ROT, b);
            //Console.WriteLine(" ");//return

            //double q0_soil;
            //Console.Write("Input the soil bering pressure value q0: ");// soil bearing pressure
            //q0_soil = double.Parse(Console.ReadLine());
            //Console.WriteLine(" ");//return    

            //local gloabl transfer     
            double[] xx_l = new double[Global.NOPNOP];//points x coordinates in local, with x-y in original point
            double[] yy_l = new double[Global.NOPNOP];//points y coordinates in local, with x-y in original point    

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_l[j] = cos * xx_g[j] - sine * yy_g[j];//x global-->local, original point at O(0,0)
                yy_l[j] = sine * xx_g[j] + cos * yy_g[j];//y global-->local, original point at O(0,0)
            }

            double bb_l;
            bb_l = cos * b;
            double y_max = Math.Abs(yy_l[0] - bb_l);
            double x_check = xx_l[0];

            for (int k = 0; k < xx_g.Length; k++)
            {
                if (Math.Abs(yy_l[k] - bb_l) > y_max)
                {
                    if (yy_l[k] > 0)
                    {
                        y_max = Math.Abs(yy_l[k] - bb_l);
                        x_check = xx_l[k];
                    }
                }
            }

            for (int jj = 0; jj < xx_g.Length; jj++) //get final x,y in local --for a certain geometry shape and a certain N.A
            {
                xx_l[jj] = Math.Round(xx_l[jj] - x_check, 3);
                yy_l[jj] = Math.Round(yy_l[jj] - cos * b, 3);
            }

            double[] k_l = new double[xx_l.Length];//slope for each line segment in global coordinate
            double[] b_l = new double[xx_l.Length];//slope for each line segment in global coordinate

            for (int ii = 0; ii < (xx_l.Length - 1); ii++)//slope
            {
                k_l[ii] = Math.Round((yy_l[ii + 1] - yy_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                b_l[ii] = Math.Round((yy_l[ii] * xx_l[ii + 1] - yy_l[ii + 1] * xx_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", ii + 1, k_l[ii], b_l[ii], xx_l[ii], xx_l[ii + 1]);//return
            }

            //last point's slope//
            int tt = Global.NOPNOP - 1;
            k_l[tt] = Math.Round((yy_l[tt] - yy_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            b_l[tt] = Math.Round((yy_l[0] * xx_l[tt] - yy_l[tt] * xx_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", Global.NOPNOP, k_l[tt], b_l[tt], xx_l[tt], xx_l[0]);//return
            //Console.WriteLine(" ");//return、、
            //local coordinates are created, ax+b for each segment is defined// 

            ///////////////////////////soil bearing pressure///////////////////////////////////
            ///////A. exterior boundary ////////////

            double[] P_l = new double[xx_l.Length];
            double[] Mx_l = new double[xx_l.Length];
            double[] My_l = new double[xx_l.Length];

            //Console.WriteLine("Input the Distribution type of the soil bering pressure.");
            //Console.WriteLine("--------(1. Uniformly, 2. Linearly, 3. Parabolic)------- ");
            //Console.WriteLine(" ");

            //Console.Write("The distribution type: ");
            //double soiltypevalue = Global.soilchoose;//initiate the choice
            double Distribute_soil = Global.soilsoil;//transfer the value


            /////////////////////////////////////////////uniformly/////////////////////////////////////////
            if (Distribute_soil == 1)
            {

                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }
                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));

                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }
                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary uniform distribution P,Mx,My are calculated//

           /////////////////////////////////////////////////////Linearly///////////////////////////////////////////////////////////////
            else if (Distribute_soil == 2)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        //My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] *(Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) * (3 * k_l[kk] * rr - b_l[kk]));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    //My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) * (3 * k_l[tt] * rr_last - b_l[tt]));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary linear distribution P,Mx,My are calculated//

            //////////////////////////////////////////////////////////////Parabolic//////////////////////////////////////////////////////
            else if (Distribute_soil == 3)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary parabolic distribution P,Mx,My are calculated//

            double P_sum = 0;
            double Mx_sum = 0;
            double My_sum = 0;
            for (int kk = 0; kk < (xx_l.Length); kk++)
            {
                P_sum += P_l[kk];
                Mx_sum += Mx_l[kk];
                My_sum += My_l[kk];
            }
            //Console.WriteLine(" ");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Axial Force P Sum is " + P_sum);
            //Console.WriteLine("Mx Sum is " + Mx_sum);
            //Console.WriteLine("My Sum is " + My_sum);
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(" ");



            ///////B. input interior opening////////
            int[] openingshape = Global.shape_OpOp;
            int numberT3 = Global.Op_NumNumNum;

            double[] P_open = new double[numberT3];
            double[] Mx_open = new double[numberT3];
            double[] My_open = new double[numberT3];


            for (int i = 0; i < numberT3; i++)
            {
                //////// circle ////////
                if (openingshape[i] == 1)
                {
                    double[] cirinfo = new double[3];
                    cirinfo = Global.op_circlecircle;

                    double theta_deg = 22.5; // 360/16 degree
                    int noc = (int)(360 / theta_deg);//number of circle points

                    double[] xx_cir = new double[noc];
                    double[] yy_cir = new double[noc];
                    double rr_circle = cirinfo[0];
                    double xx_cir_centgl = cirinfo[1];
                    double yy_cir_centgl = cirinfo[2];

                    double xx_cir_centloc = cos * xx_cir_centgl - sine * yy_cir_centgl - x_check; //circle center in local
                    double yy_cir_centloc = sine * xx_cir_centgl + cos * yy_cir_centgl - cos * b;  //circle center in local

                    for (int j = 0; j < xx_cir.Length; j++) //get cir points' x,y in local
                    {
                        double theta_cir = theta_deg * (j) * (Math.PI / 180);//counterclockwise
                        xx_cir[j] = Math.Round(xx_cir_centloc - rr_circle * Math.Sin(theta_cir), 3);
                        yy_cir[j] = Math.Round(yy_cir_centloc + rr_circle * Math.Cos(theta_cir), 3);
                    }

                    //circle exterior boundaries' slopes//
                    double[] k_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate
                    double[] b_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate

                    for (int ii = 0; ii < (xx_cir.Length - 1); ii++)//slope
                    {
                        k_cir[ii] = Math.Round((yy_cir[ii + 1] - yy_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                        b_cir[ii] = Math.Round((yy_cir[ii] * xx_cir[ii + 1] - yy_cir[ii + 1] * xx_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                    }
                    //last point's slope//
                    k_cir[noc - 1] = Math.Round((yy_cir[noc - 1] - yy_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);
                    b_cir[noc - 1] = Math.Round((yy_cir[0] * xx_cir[noc - 1] - yy_cir[noc - 1] * xx_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_cir = new double[xx_cir.Length];
                    double[] Mx_cir = new double[xx_cir.Length];
                    double[] My_cir = new double[xx_cir.Length];

                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));

                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }

                    }
                    // interior circle opening uniform distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));

                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening parabolic distribution P,Mx,My are calculated//

                    //////////////////sum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (noc); kkk++)
                    {
                        P_open[i] += P_cir[kkk];
                        Mx_open[i] += Mx_cir[kkk];
                        My_open[i] += My_cir[kkk];
                    }

                    //Console.WriteLine(" ");
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    //Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    //Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }

                /////////////////////////// poly //////////////////////////////////////////////////

                if (openingshape[i] == 2)
                {
                    //int poly1 = Global.poly_NOP;
                    int poly = Global.poly_NOPNOPNOP;
                    double[] poly_x_info = new double[poly];
                    double[] poly_y_info = new double[poly];
                    poly_x_info = Global.x_polypoly;
                    poly_y_info = Global.y_polypoly;

                    //double[] theta_cir = new double[noc];
                    double[] xx_g_pol = new double[poly];
                    double[] yy_g_pol = new double[poly];
                    for (int iii = 0; iii < poly; iii++)
                    {
                        //Console.Write("Input the {0} points' x coordinate in global:", (iii + 1));
                        xx_g_pol[iii] = poly_x_info[iii];
                        //Console.Write("Input the {0} points' y coordinate in global:", (iii + 1));
                        yy_g_pol[iii] = poly_y_info[iii];
                        //Console.WriteLine(" ");
                    }


                    //local gloabl transfer     
                    double[] xx_pol = new double[poly];//points x coordinates in local, with x-y in original point
                    double[] yy_pol = new double[poly];//points y coordinates in local, with x-y in original point    

                    for (int j = 0; j < poly; j++)
                    {
                        xx_pol[j] = cos * xx_g_pol[j] - sine * yy_g_pol[j] - x_check;//x global-->local, original point at O(0,0)
                        yy_pol[j] = sine * xx_g_pol[j] + cos * yy_g_pol[j] - cos * b;//y global-->local, original point at O(0,0)
                    }
                    //exterior boundaries' slopes//
                    double[] k_pol = new double[poly];//slope for each line segment in local coordinate
                    double[] b_pol = new double[poly];//slope for each line segment in local coordinate

                    for (int ii = 0; ii < (poly - 1); ii++)//slope
                    {
                        k_pol[ii] = Math.Round((yy_pol[ii + 1] - yy_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                        b_pol[ii] = Math.Round((yy_pol[ii] * xx_pol[ii + 1] - yy_pol[ii + 1] * xx_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                    }
                    //last point's slope//
                    k_pol[poly - 1] = Math.Round((yy_pol[poly - 1] - yy_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    b_pol[poly - 1] = Math.Round((yy_pol[0] * xx_pol[poly - 1] - yy_pol[poly - 1] * xx_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    // Geometry input for the polygon//

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_pol = new double[poly];
                    double[] Mx_pol = new double[poly];
                    double[] My_pol = new double[poly];
                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (poly - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));

                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }

                    }
                    // interior polygon opening uniform distribution P,Mx,My are calculated//

                ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));

                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening parabolic distribution P,Mx,My are calculated//

                    //////////////////ttsum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (poly); kkk++)
                    {
                        P_open[i] += P_pol[kkk];
                        Mx_open[i] += Mx_pol[kkk];
                        My_open[i] += My_pol[kkk];
                    }

                    //Console.WriteLine(" ");
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    //Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    //Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }
            }

            //////sum of the P, Mx and My/////
            double P_open_sum = 0;
            double Mx_open_sum = 0;
            double My_open_sum = 0;
            for (int i = 0; i < P_open.Length; i++)
            {
                P_open_sum += P_open[i];
                Mx_open_sum += Mx_open[i];
                My_open_sum += My_open[i];
            }

            /////////sum of all the parts////////
            double PP = P_sum + P_open_sum;
            double MxMx = Mx_sum + Mx_open_sum;
            double MyMy = My_sum + My_open_sum;
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Total Axial Force is {0}", PP);
            //Console.WriteLine("Total Moment about x axis (Mx) is {0}", MxMx);
            //Console.WriteLine("Total Moment about y axis (My) is {0}", MyMy);
            //Console.WriteLine("-------------------------------------");

            return MxMx;
        }
        ///////////////////////////////////////////////////////////////////////
        static double H(double slope, double b, double q0_soil)
        {
            //download the global value

            double[] xx_g = new double[Global.NOPNOP];
            double[] yy_g = new double[Global.NOPNOP];
            //xx_g[0] = Tim1(0);//maybe every iteration you need to input once
            //yy_g[0] = Tim2(0);

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_g[j] = Global.X_global[j];
                yy_g[j] = Global.Y_global[j];
            }


            double ROT;//The fixed Neutral Axis angle for now

            ROT = Math.Atan(slope) * (180 / Math.PI);//-90~90
            //Console.WriteLine("In this step, the Neutral Axis Angle is {0}.", ROT);
            //Console.WriteLine(" ");
            double radians_ROT = ROT * (Math.PI / 180);
            //double slope_ROT = Math.Tan(radians_ROT);//slope for the neutral axis in global
            double sine = Math.Sin(-radians_ROT);//sine of local， inverse transform
            double cos = Math.Cos(-radians_ROT);//cosine of local

            //double b;//y-intercept
            //Console.Write("Y-Intercept is: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("The function of Neutral Axis in Global is y = {0}x+ {1}", slope_ROT, b);
            //Console.WriteLine(" ");//return

            //double q0_soil;
            //Console.Write("Input the soil bering pressure value q0: ");// soil bearing pressure
            //q0_soil = double.Parse(Console.ReadLine());
            //Console.WriteLine(" ");//return    

            //local gloabl transfer     
            double[] xx_l = new double[Global.NOPNOP];//points x coordinates in local, with x-y in original point
            double[] yy_l = new double[Global.NOPNOP];//points y coordinates in local, with x-y in original point    

            for (int j = 0; j < Global.NOPNOP; j++)
            {
                xx_l[j] = cos * xx_g[j] - sine * yy_g[j];//x global-->local, original point at O(0,0)
                yy_l[j] = sine * xx_g[j] + cos * yy_g[j];//y global-->local, original point at O(0,0)
            }

            double bb_l;
            bb_l = cos * b;
            double y_max = Math.Abs(yy_l[0] - bb_l);
            double x_check = xx_l[0];

            for (int k = 0; k < xx_g.Length; k++)
            {
                if (Math.Abs(yy_l[k] - bb_l) > y_max)
                {
                    if (yy_l[k] > 0)
                    {
                        y_max = Math.Abs(yy_l[k] - bb_l);
                        x_check = xx_l[k];
                    }
                }
            }

            for (int jj = 0; jj < xx_g.Length; jj++) //get final x,y in local --for a certain geometry shape and a certain N.A
            {
                xx_l[jj] = Math.Round(xx_l[jj] - x_check, 3);
                yy_l[jj] = Math.Round(yy_l[jj] - cos * b, 3);
            }

            double[] k_l = new double[xx_l.Length];//slope for each line segment in global coordinate
            double[] b_l = new double[xx_l.Length];//slope for each line segment in global coordinate

            for (int ii = 0; ii < (xx_l.Length - 1); ii++)//slope
            {
                k_l[ii] = Math.Round((yy_l[ii + 1] - yy_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                b_l[ii] = Math.Round((yy_l[ii] * xx_l[ii + 1] - yy_l[ii + 1] * xx_l[ii]) / (xx_l[ii + 1] - xx_l[ii]), 3);
                //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", ii + 1, k_l[ii], b_l[ii], xx_l[ii], xx_l[ii + 1]);//return
            }

            //last point's slope//
            int tt = Global.NOPNOP - 1;
            k_l[tt] = Math.Round((yy_l[tt] - yy_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            b_l[tt] = Math.Round((yy_l[0] * xx_l[tt] - yy_l[tt] * xx_l[0]) / (xx_l[tt] - xx_l[0]), 3);
            //Console.WriteLine("The {0} local exterior boundary expression is: y = {1} x + {2}, x: ({3} : {4})", Global.NOPNOP, k_l[tt], b_l[tt], xx_l[tt], xx_l[0]);//return
            //Console.WriteLine(" ");//return、、
            //local coordinates are created, ax+b for each segment is defined// 

            ///////////////////////////soil bearing pressure///////////////////////////////////
            ///////A. exterior boundary ////////////

            double[] P_l = new double[xx_l.Length];
            double[] Mx_l = new double[xx_l.Length];
            double[] My_l = new double[xx_l.Length];

            //Console.WriteLine("Input the Distribution type of the soil bering pressure.");
            //Console.WriteLine("--------(1. Uniformly, 2. Linearly, 3. Parabolic)------- ");
            //Console.WriteLine(" ");

            //Console.Write("The distribution type: ");
            //double soiltypevalue = Global.soilchoose;//initiate the choice
            double Distribute_soil = Global.soilsoil;//transfer the value


            /////////////////////////////////////////////uniformly/////////////////////////////////////////
            if (Distribute_soil == 1)
            {

                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }
                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil * (ss * (k_l[kk] * ss / 2 + b_l[kk]) - rr * (k_l[kk] * rr / 2 + b_l[kk]));
                        My_l[kk] = q0_soil * (k_l[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_l[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                        Mx_l[kk] = q0_soil / 6 / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));

                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil * (ss_last * (k_l[tt] * ss_last / 2 + b_l[tt]) - rr_last * (k_l[tt] * rr_last / 2 + b_l[tt]));
                    My_l[tt] = q0_soil * (k_l[tt] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_l[tt] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                    Mx_l[tt] = q0_soil / 6 / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                }
                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary uniform distribution P,Mx,My are calculated//

           /////////////////////////////////////////////////////Linearly///////////////////////////////////////////////////////////////
            else if (Distribute_soil == 2)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        //My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] *(Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) * (3 * k_l[kk] * rr - b_l[kk]));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = q0_soil / 6 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3));
                        Mx_l[kk] = q0_soil / 12 / y_max / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 4) - Math.Pow((k_l[kk] * rr + b_l[kk]), 4));
                        My_l[kk] = q0_soil / 24 / y_max / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3) * (3 * k_l[kk] * ss - b_l[kk]) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3) * (3 * k_l[kk] * rr - b_l[kk]));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    //My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) * (3 * k_l[tt] * rr_last - b_l[tt]));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = q0_soil / 6 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3));
                    Mx_l[tt] = q0_soil / 12 / y_max / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 4) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 4));
                    My_l[tt] = q0_soil / 24 / y_max / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3) * (3 * k_l[tt] * ss_last - b_l[tt]) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3) * (3 * k_l[tt] * rr_last - b_l[tt]));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary linear distribution P,Mx,My are calculated//

            //////////////////////////////////////////////////////////////Parabolic//////////////////////////////////////////////////////
            else if (Distribute_soil == 3)
            {
                for (int kk = 0; kk < (xx_l.Length - 1); kk++)
                {
                    double rr = 0;
                    double ss = 0;
                    if (yy_l[kk] >= 0 && yy_l[kk + 1] >= 0)
                    {
                        rr = xx_l[kk];
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] >= 0 && yy_l[kk + 1] < 0)
                    {
                        double T = yy_l[kk] * (xx_l[kk + 1] - xx_l[kk]) / (yy_l[kk] - yy_l[kk + 1]);
                        rr = xx_l[kk];
                        ss = xx_l[kk] + T;
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else if (yy_l[kk] < 0 && yy_l[kk + 1] >= 0)
                    {
                        double T = yy_l[kk + 1] * (xx_l[kk] - xx_l[kk + 1]) / (yy_l[kk + 1] - yy_l[kk]);
                        rr = xx_l[kk + 1] + T;
                        ss = xx_l[kk + 1];
                        P_l[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                        Mx_l[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 3.5) - Math.Pow((k_l[kk] * rr + b_l[kk]), 3.5));
                        My_l[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[kk] / k_l[kk] * (Math.Pow((k_l[kk] * ss + b_l[kk]), 2.5) * (5 * k_l[kk] * ss - 2 * b_l[kk]) - (5 * k_l[kk] * rr - 2 * b_l[kk]) * Math.Pow((k_l[kk] * rr + b_l[kk]), 2.5));
                    }

                    else
                    {
                        P_l[kk] = 0;
                        Mx_l[kk] = 0;
                        My_l[kk] = 0;
                    }
                }
                //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                if (yy_l[tt] >= 0 && yy_l[0] >= 0)
                {
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] >= 0 && yy_l[0] < 0)
                {
                    double T = yy_l[tt] * (xx_l[0] - xx_l[tt]) / (yy_l[tt] - yy_l[0]);
                    double rr_last = xx_l[tt];
                    double ss_last = xx_l[tt] + T;
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else if (yy_l[tt] < 0 && yy_l[0] >= 0)
                {
                    double T = yy_l[0] * (xx_l[tt] - xx_l[0]) / (yy_l[0] - yy_l[tt]);
                    double rr_last = xx_l[0] + T;
                    double ss_last = xx_l[0];
                    P_l[tt] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));
                    Mx_l[tt] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 3.5) - Math.Pow((k_l[tt] * rr_last + b_l[tt]), 3.5));
                    My_l[tt] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_l[tt] / k_l[tt] * (Math.Pow((k_l[tt] * ss_last + b_l[tt]), 2.5) * (5 * k_l[tt] * ss_last - 2 * b_l[tt]) - (5 * k_l[tt] * rr_last - 2 * b_l[tt]) * Math.Pow((k_l[tt] * rr_last + b_l[tt]), 2.5));

                }

                else
                {
                    P_l[tt] = 0;
                    Mx_l[tt] = 0;
                    My_l[tt] = 0;
                }

            }
            // exterior boundary parabolic distribution P,Mx,My are calculated//

            double P_sum = 0;
            double Mx_sum = 0;
            double My_sum = 0;
            for (int kk = 0; kk < (xx_l.Length); kk++)
            {
                P_sum += P_l[kk];
                Mx_sum += Mx_l[kk];
                My_sum += My_l[kk];
            }
            //Console.WriteLine(" ");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Axial Force P Sum is " + P_sum);
            //Console.WriteLine("Mx Sum is " + Mx_sum);
            //Console.WriteLine("My Sum is " + My_sum);
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine(" ");



            ///////B. input interior opening////////
            int[] openingshape = Global.shape_OpOp;
            int numberT3 = Global.Op_NumNumNum;

            double[] P_open = new double[numberT3];
            double[] Mx_open = new double[numberT3];
            double[] My_open = new double[numberT3];


            for (int i = 0; i < numberT3; i++)
            {
                //////// circle ////////
                if (openingshape[i] == 1)
                {
                    double[] cirinfo = new double[3];
                    cirinfo = Global.op_circlecircle;

                    double theta_deg = 22.5; // 360/16 degree
                    int noc = (int)(360 / theta_deg);//number of circle points

                    double[] xx_cir = new double[noc];
                    double[] yy_cir = new double[noc];
                    double rr_circle = cirinfo[0];
                    double xx_cir_centgl = cirinfo[1];
                    double yy_cir_centgl = cirinfo[2];

                    double xx_cir_centloc = cos * xx_cir_centgl - sine * yy_cir_centgl - x_check; //circle center in local
                    double yy_cir_centloc = sine * xx_cir_centgl + cos * yy_cir_centgl - cos * b;  //circle center in local

                    for (int j = 0; j < xx_cir.Length; j++) //get cir points' x,y in local
                    {
                        double theta_cir = theta_deg * (j) * (Math.PI / 180);//counterclockwise
                        xx_cir[j] = Math.Round(xx_cir_centloc - rr_circle * Math.Sin(theta_cir), 3);
                        yy_cir[j] = Math.Round(yy_cir_centloc + rr_circle * Math.Cos(theta_cir), 3);
                    }

                    //circle exterior boundaries' slopes//
                    double[] k_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate
                    double[] b_cir = new double[xx_cir.Length];//slope for each line segment in global coordinate

                    for (int ii = 0; ii < (xx_cir.Length - 1); ii++)//slope
                    {
                        k_cir[ii] = Math.Round((yy_cir[ii + 1] - yy_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                        b_cir[ii] = Math.Round((yy_cir[ii] * xx_cir[ii + 1] - yy_cir[ii + 1] * xx_cir[ii]) / (xx_cir[ii + 1] - xx_cir[ii]), 3);
                    }
                    //last point's slope//
                    k_cir[noc - 1] = Math.Round((yy_cir[noc - 1] - yy_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);
                    b_cir[noc - 1] = Math.Round((yy_cir[0] * xx_cir[noc - 1] - yy_cir[noc - 1] * xx_cir[0]) / (xx_cir[noc - 1] - xx_cir[0]), 3);

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_cir = new double[xx_cir.Length];
                    double[] Mx_cir = new double[xx_cir.Length];
                    double[] My_cir = new double[xx_cir.Length];

                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil * (ss * (k_cir[kk] * ss / 2 + b_cir[kk]) - rr * (k_cir[kk] * rr / 2 + b_cir[kk]));
                                My_cir[kk] = q0_soil * (k_cir[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_cir[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_cir[kk] = q0_soil / 6 / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));

                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil * (ss_last * (k_cir[noc - 1] * ss_last / 2 + b_cir[noc - 1]) - rr_last * (k_cir[noc - 1] * rr_last / 2 + b_cir[noc - 1]));
                            My_cir[noc - 1] = q0_soil * (k_cir[noc - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_cir[noc - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_cir[noc - 1] = q0_soil / 6 / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }

                    }
                    // interior circle opening uniform distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = q0_soil / 6 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3));
                                Mx_cir[kk] = q0_soil / 12 / y_max / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 4) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 4));
                                My_cir[kk] = q0_soil / 24 / y_max / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3) * (3 * k_cir[kk] * ss - b_cir[kk]) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3) * (3 * k_cir[kk] * rr - b_cir[kk]));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = q0_soil / 6 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3));
                            Mx_cir[noc - 1] = q0_soil / 12 / y_max / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 4) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 4));
                            My_cir[noc - 1] = q0_soil / 24 / y_max / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * ss_last - b_cir[noc - 1]) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3) * (3 * k_cir[noc - 1] * rr_last - b_cir[noc - 1]));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_cir.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_cir[kk] >= 0 && yy_cir[kk + 1] >= 0)
                            {
                                rr = xx_cir[kk];
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));

                            }
                            else if (yy_cir[kk] >= 0 && yy_cir[kk + 1] < 0)
                            {
                                double T = yy_cir[kk] * (xx_cir[kk + 1] - xx_cir[kk]) / (yy_cir[kk] - yy_cir[kk + 1]);
                                rr = xx_cir[kk];
                                ss = xx_cir[kk] + T;
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else if (yy_cir[kk] < 0 && yy_cir[kk + 1] >= 0)
                            {
                                double T = yy_cir[kk + 1] * (xx_cir[kk] - xx_cir[kk + 1]) / (yy_cir[kk + 1] - yy_cir[kk]);
                                rr = xx_cir[kk + 1] + T;
                                ss = xx_cir[kk + 1];
                                P_cir[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                                Mx_cir[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 3.5) - Math.Pow((k_cir[kk] * rr + b_cir[kk]), 3.5));
                                My_cir[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[kk] / k_cir[kk] * (Math.Pow((k_cir[kk] * ss + b_cir[kk]), 2.5) * (5 * k_cir[kk] * ss - 2 * b_cir[kk]) - (5 * k_cir[kk] * rr - 2 * b_cir[kk]) * Math.Pow((k_cir[kk] * rr + b_cir[kk]), 2.5));
                            }

                            else
                            {
                                P_cir[kk] = 0;
                                Mx_cir[kk] = 0;
                                My_cir[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_cir[noc - 1] >= 0 && yy_cir[0] >= 0)
                        {
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));

                        }

                        else if (yy_cir[noc - 1] >= 0 && yy_cir[0] < 0)
                        {
                            double T = yy_cir[noc - 1] * (xx_cir[0] - xx_cir[noc - 1]) / (yy_cir[noc - 1] - yy_cir[0]);
                            double rr_last = xx_cir[noc - 1];
                            double ss_last = xx_cir[noc - 1] + T;
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }

                        else if (yy_cir[noc - 1] < 0 && yy_cir[0] >= 0)
                        {
                            double T = yy_cir[0] * (xx_cir[noc - 1] - xx_cir[0]) / (yy_cir[0] - yy_cir[noc - 1]);
                            double rr_last = xx_cir[0] + T;
                            double ss_last = xx_cir[0];
                            P_cir[noc - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                            Mx_cir[noc - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 3.5) - Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 3.5));
                            My_cir[noc - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_cir[noc - 1] / k_cir[noc - 1] * (Math.Pow((k_cir[noc - 1] * ss_last + b_cir[noc - 1]), 2.5) * (5 * k_cir[noc - 1] * ss_last - 2 * b_cir[noc - 1]) - (5 * k_cir[noc - 1] * rr_last - 2 * b_cir[noc - 1]) * Math.Pow((k_cir[noc - 1] * rr_last + b_cir[noc - 1]), 2.5));
                        }
                        else
                        {
                            P_cir[noc - 1] = 0;
                            Mx_cir[noc - 1] = 0;
                            My_cir[noc - 1] = 0;
                        }
                    }
                    // interior circle opening parabolic distribution P,Mx,My are calculated//

                    //////////////////sum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (noc); kkk++)
                    {
                        P_open[i] += P_cir[kkk];
                        Mx_open[i] += Mx_cir[kkk];
                        My_open[i] += My_cir[kkk];
                    }

                    //Console.WriteLine(" ");
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    //Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    //Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }

                /////////////////////////// poly //////////////////////////////////////////////////

                if (openingshape[i] == 2)
                {
                    //int poly1 = Global.poly_NOP;
                    int poly = Global.poly_NOPNOPNOP;
                    double[] poly_x_info = new double[poly];
                    double[] poly_y_info = new double[poly];
                    poly_x_info = Global.x_polypoly;
                    poly_y_info = Global.y_polypoly;

                    //double[] theta_cir = new double[noc];
                    double[] xx_g_pol = new double[poly];
                    double[] yy_g_pol = new double[poly];
                    for (int iii = 0; iii < poly; iii++)
                    {
                        //Console.Write("Input the {0} points' x coordinate in global:", (iii + 1));
                        xx_g_pol[iii] = poly_x_info[iii];
                        //Console.Write("Input the {0} points' y coordinate in global:", (iii + 1));
                        yy_g_pol[iii] = poly_y_info[iii];
                        //Console.WriteLine(" ");
                    }


                    //local gloabl transfer     
                    double[] xx_pol = new double[poly];//points x coordinates in local, with x-y in original point
                    double[] yy_pol = new double[poly];//points y coordinates in local, with x-y in original point    

                    for (int j = 0; j < poly; j++)
                    {
                        xx_pol[j] = cos * xx_g_pol[j] - sine * yy_g_pol[j] - x_check;//x global-->local, original point at O(0,0)
                        yy_pol[j] = sine * xx_g_pol[j] + cos * yy_g_pol[j] - cos * b;//y global-->local, original point at O(0,0)
                    }
                    //exterior boundaries' slopes//
                    double[] k_pol = new double[poly];//slope for each line segment in local coordinate
                    double[] b_pol = new double[poly];//slope for each line segment in local coordinate

                    for (int ii = 0; ii < (poly - 1); ii++)//slope
                    {
                        k_pol[ii] = Math.Round((yy_pol[ii + 1] - yy_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                        b_pol[ii] = Math.Round((yy_pol[ii] * xx_pol[ii + 1] - yy_pol[ii + 1] * xx_pol[ii]) / (xx_pol[ii + 1] - xx_pol[ii]), 3);
                    }
                    //last point's slope//
                    k_pol[poly - 1] = Math.Round((yy_pol[poly - 1] - yy_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    b_pol[poly - 1] = Math.Round((yy_pol[0] * xx_pol[poly - 1] - yy_pol[poly - 1] * xx_pol[0]) / (xx_pol[poly - 1] - xx_pol[0]), 3);
                    // Geometry input for the polygon//

                    ////////////////////////////////////////////////soil bearing//////////////////////////////////////////////
                    double[] P_pol = new double[poly];
                    double[] Mx_pol = new double[poly];
                    double[] My_pol = new double[poly];
                    ////////////////////////////////////////////////1. Uniform///////////////////////////////////////////////
                    if (Distribute_soil == 1)
                    {
                        for (int kk = 0; kk < (poly - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil * (ss * (k_pol[kk] * ss / 2 + b_pol[kk]) - rr * (k_pol[kk] * rr / 2 + b_pol[kk]));
                                My_pol[kk] = q0_soil * (k_pol[kk] / 3 * (Math.Pow(ss, 3) - Math.Pow(rr, 3)) + b_pol[kk] / 2 * (Math.Pow(ss, 2) - Math.Pow(rr, 2)));
                                Mx_pol[kk] = q0_soil / 6 / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));

                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil * (ss_last * (k_pol[poly - 1] * ss_last / 2 + b_pol[poly - 1]) - rr_last * (k_pol[poly - 1] * rr_last / 2 + b_pol[poly - 1]));
                            My_pol[poly - 1] = q0_soil * (k_pol[poly - 1] / 3 * (Math.Pow(ss_last, 3) - Math.Pow(rr_last, 3)) + b_pol[poly - 1] / 2 * (Math.Pow(ss_last, 2) - Math.Pow(rr_last, 2)));
                            Mx_pol[poly - 1] = q0_soil / 6 / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }

                    }
                    // interior polygon opening uniform distribution P,Mx,My are calculated//

                ////////////////////////////////////////////////////////Linear/////////////////////////////////////////
                    else if (Distribute_soil == 2)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = q0_soil / 6 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3));
                                Mx_pol[kk] = q0_soil / 12 / y_max / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 4) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 4));
                                My_pol[kk] = q0_soil / 24 / y_max / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3) * (3 * k_pol[kk] * ss - b_pol[kk]) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3) * (3 * k_pol[kk] * rr - b_pol[kk]));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = q0_soil / 6 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3));
                            Mx_pol[poly - 1] = q0_soil / 12 / y_max / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 4) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 4));
                            My_pol[poly - 1] = q0_soil / 24 / y_max / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * ss_last - b_pol[poly - 1]) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3) * (3 * k_pol[poly - 1] * rr_last - b_pol[poly - 1]));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening linear distribution P,Mx,My are calculated//

                        ////////////////////////////////////////////////////////Parabolic/////////////////////////////////////////
                    else if (Distribute_soil == 3)
                    {
                        for (int kk = 0; kk < (xx_pol.Length - 1); kk++)
                        {
                            double rr = 0;
                            double ss = 0;
                            if (yy_pol[kk] >= 0 && yy_pol[kk + 1] >= 0)
                            {
                                rr = xx_pol[kk];
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));

                            }
                            else if (yy_pol[kk] >= 0 && yy_pol[kk + 1] < 0)
                            {
                                double T = yy_pol[kk] * (xx_pol[kk + 1] - xx_pol[kk]) / (yy_pol[kk] - yy_pol[kk + 1]);
                                rr = xx_pol[kk];
                                ss = xx_pol[kk] + T;
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else if (yy_pol[kk] < 0 && yy_pol[kk + 1] >= 0)
                            {
                                double T = yy_pol[kk + 1] * (xx_pol[kk] - xx_pol[kk + 1]) / (yy_pol[kk + 1] - yy_pol[kk]);
                                rr = xx_pol[kk + 1] + T;
                                ss = xx_pol[kk + 1];
                                P_pol[kk] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                                Mx_pol[kk] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 3.5) - Math.Pow((k_pol[kk] * rr + b_pol[kk]), 3.5));
                                My_pol[kk] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[kk] / k_pol[kk] * (Math.Pow((k_pol[kk] * ss + b_pol[kk]), 2.5) * (5 * k_pol[kk] * ss - 2 * b_pol[kk]) - (5 * k_pol[kk] * rr - 2 * b_pol[kk]) * Math.Pow((k_pol[kk] * rr + b_pol[kk]), 2.5));
                            }

                            else
                            {
                                P_pol[kk] = 0;
                                Mx_pol[kk] = 0;
                                My_pol[kk] = 0;
                            }
                        }
                        //last point//if the two points happen to across the x-axis, a triangle part is not considered, need to be fixed later

                        if (yy_pol[poly - 1] >= 0 && yy_pol[0] >= 0)
                        {
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));

                        }

                        else if (yy_pol[poly - 1] >= 0 && yy_pol[0] < 0)
                        {
                            double T = yy_pol[poly - 1] * (xx_pol[0] - xx_pol[poly - 1]) / (yy_pol[poly - 1] - yy_pol[0]);
                            double rr_last = xx_pol[poly - 1];
                            double ss_last = xx_pol[poly - 1] + T;
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }

                        else if (yy_pol[poly - 1] < 0 && yy_pol[0] >= 0)
                        {
                            double T = yy_pol[0] * (xx_pol[poly - 1] - xx_pol[0]) / (yy_pol[0] - yy_pol[poly - 1]);
                            double rr_last = xx_pol[0] + T;
                            double ss_last = xx_pol[0];
                            P_pol[poly - 1] = 4 * q0_soil / 15 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                            Mx_pol[poly - 1] = 4 * q0_soil / 35 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 3.5) - Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 3.5));
                            My_pol[poly - 1] = 4 * q0_soil / 105 / Math.Pow(y_max, 0.5) / k_pol[poly - 1] / k_pol[poly - 1] * (Math.Pow((k_pol[poly - 1] * ss_last + b_pol[poly - 1]), 2.5) * (5 * k_pol[poly - 1] * ss_last - 2 * b_pol[poly - 1]) - (5 * k_pol[poly - 1] * rr_last - 2 * b_pol[poly - 1]) * Math.Pow((k_pol[poly - 1] * rr_last + b_pol[poly - 1]), 2.5));
                        }
                        else
                        {
                            P_pol[poly - 1] = 0;
                            Mx_pol[poly - 1] = 0;
                            My_pol[poly - 1] = 0;
                        }
                    }
                    // interior polygon opening parabolic distribution P,Mx,My are calculated//

                    //////////////////ttsum all the 16 point's force/////////////////////////////
                    for (int kkk = 0; kkk < (poly); kkk++)
                    {
                        P_open[i] += P_pol[kkk];
                        Mx_open[i] += Mx_pol[kkk];
                        My_open[i] += My_pol[kkk];
                    }

                    //Console.WriteLine(" ");
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine("The {0} Opening Axial Force P Sum is {1} ", (i + 1), P_open[i]);
                    //Console.WriteLine("The {0} Opening Mx is {1} ", (i + 1), Mx_open[i]);
                    //Console.WriteLine("The {0} Opening My is {1} ", (i + 1), My_open[i]);
                    //Console.WriteLine("-------------------------------------");
                    //Console.WriteLine(" ");
                }
            }

            //////sum of the P, Mx and My/////
            double P_open_sum = 0;
            double Mx_open_sum = 0;
            double My_open_sum = 0;
            for (int i = 0; i < P_open.Length; i++)
            {
                P_open_sum += P_open[i];
                Mx_open_sum += Mx_open[i];
                My_open_sum += My_open[i];
            }

            /////////sum of all the parts////////
            double PP = P_sum + P_open_sum;
            double MxMx = Mx_sum + Mx_open_sum;
            double MyMy = My_sum + My_open_sum;
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Total Axial Force is {0}", PP);
            //Console.WriteLine("Total Moment about x axis (Mx) is {0}", MxMx);
            //Console.WriteLine("Total Moment about y axis (My) is {0}", MyMy);
            //Console.WriteLine("-------------------------------------");

            return MyMy;
        }
        ///////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            //main class//
            ///////////////////////////Geometry Input///////////////////////////////////
            //exterior boundary//
            Console.WriteLine("-----------------------------Irregular Shape Spread Footing Design Tool-----------------------------");//First thing First
            Console.WriteLine("----------------------------------Developed by University of Houston--------------------------------");//First thing First
            Console.WriteLine("-------------------------------Sponsored by Dimensional Solutions, Inc------------------------------");//First thing First
            Console.Write(" ");


            //Console.Write("Number of Footing Points: "); //first global parameter
            int RT = Global.NOP;
            //Console.WriteLine("The Number of Footing Points is {0}!", RT); //show the NOP value inputted in the global class
            Console.WriteLine(" ");

            Console.WriteLine("Step2: Input the Design Loads: ");
            //Console.WriteLine(" "); 
            Console.Write("The Design P of the footing is: ");
            double P0 = double.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            Console.Write("The Design Mx of the footing is: ");
            double Mx0 = double.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            Console.Write("The Design My of the footing is: ");
            double My0 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");


            //initial ROT,b,q0
            //neutral axis fixed temporary for this stage, simplified method//
            double ROT;//The fixed Neutral Axis angle for now
            Console.WriteLine("Step3: Initial Status Setting: ");
            //Console.WriteLine(" "); 
            Console.Write("The Initial Neutral Axis Angle is (degree): ");
            ROT = double.Parse(Console.ReadLine());//-90~90
            double radians_ROT = ROT * (Math.PI / 180);
            double slope_ROT = Math.Tan(radians_ROT);//slope for the neutral axis in global
            //double sine = Math.Sin(-radians_ROT);//sine of local， inverse transform
            //double cos = Math.Cos(-radians_ROT);//cosine of local

            //////////////////////////////////////////////////
            double b;//y-intercept
            Console.Write("The initial Y-Intercept is: ");
            Console.Write(" ");
            b = double.Parse(Console.ReadLine());
            //Console.WriteLine("The Initial Express of Neutral Axis in Global Coordination is y = {0}x+ {1}", slope_ROT, b);
            //Console.WriteLine(" ");//return

            ////////////////////////////////////////////////////
            double q0_soil;
            Console.Write("The initial soil bearing pressure value q0 is: ");// soil bearing pressure
            q0_soil = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");//return    

            /////////////////////////////////////////////////////
            Console.WriteLine("Step4: Iteration Setting: ");
            //Console.WriteLine(" "); 
            double[] iteriter = Global.delta_iter1;
            double[] iter = Global.delta_iter2;
            double iter1 = iter[0];//A
            double iter2 = iter[1];//b
            double iter3 = iter[2];//q0

            int ITER = 5000;

            double[] a0 = new double[ITER];
            double[] b0 = new double[ITER];
            double[] c0 = new double[ITER];

            a0[0] = slope_ROT;
            b0[0] = b;
            c0[0] = q0_soil;

            double F0 = P0;
            double G0 = Mx0;
            double H0 = My0;

            double[] F1 = new double[ITER];
            double[] G1 = new double[ITER];
            double[] H1 = new double[ITER];
            double[] f_x = new double[ITER];
            double[] f_y = new double[ITER];
            double[] f_z = new double[ITER];
            double[] g_x = new double[ITER];
            double[] g_y = new double[ITER];
            double[] g_z = new double[ITER];
            double[] h_x = new double[ITER];
            double[] h_y = new double[ITER];
            double[] h_z = new double[ITER];

            double[] f = new double[ITER];
            double[] g = new double[ITER];
            double[] h = new double[ITER];
            double[] DET = new double[ITER];

            double[] D_x = new double[ITER];
            double[] D_y = new double[ITER];
            double[] D_z = new double[ITER];
            ////////////////////////////////////////////////////////
            double p1 = Tim1_P(slope_ROT, b, q0_soil);
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to start iteration");
            string conf1 = (Console.ReadLine());
           
            // iteration
            for (int i = 1; i < ITER; i++)
            {
                F1[i - 1] = F(a0[i - 1], b0[i - 1], c0[i - 1]);
                G1[i - 1] = G(a0[i - 1], b0[i - 1], c0[i - 1]);
                H1[i - 1] = H(a0[i - 1], b0[i - 1], c0[i - 1]);

                f[i - 1] = ((F1[i - 1]) - (F0));
                g[i - 1] = ((G1[i - 1]) - (G0));
                h[i - 1] = ((H1[i - 1]) - (H0));

                f_x[i - 1] = (F(a0[i - 1] + iter1, b0[i - 1], c0[i - 1]) - F(a0[i - 1] - iter1, b0[i - 1], c0[i - 1])) / 2 / iter1;
                f_y[i - 1] = (F(a0[i - 1], b0[i - 1] + iter2, c0[i - 1]) - F(a0[i - 1], b0[i - 1] - iter2, c0[i - 1])) / 2 / iter2;
                f_z[i - 1] = (F(a0[i - 1], b0[i - 1], c0[i - 1] + iter3) - F(a0[i - 1], b0[i - 1], c0[i - 1] - iter3)) / 2 / iter3;

                g_x[i - 1] = (G(a0[i - 1] + iter1, b0[i - 1], c0[i - 1]) - G(a0[i - 1] - iter1, b0[i - 1], c0[i - 1])) / 2 / iter1;
                g_y[i - 1] = (G(a0[i - 1], b0[i - 1] + iter2, c0[i - 1]) - G(a0[i - 1], b0[i - 1] - iter2, c0[i - 1])) / 2 / iter2;
                g_z[i - 1] = (G(a0[i - 1], b0[i - 1], c0[i - 1] + iter3) - G(a0[i - 1], b0[i - 1], c0[i - 1] - iter3)) / 2 / iter3;

                h_x[i - 1] = (H(a0[i - 1] + iter1, b0[i - 1], c0[i - 1]) - H(a0[i - 1] - iter1, b0[i - 1], c0[i - 1])) / 2 / iter1;
                h_y[i - 1] = (H(a0[i - 1], b0[i - 1] + iter2, c0[i - 1]) - H(a0[i - 1], b0[i - 1] - iter2, c0[i - 1])) / 2 / iter2;
                h_z[i - 1] = (H(a0[i - 1], b0[i - 1], c0[i - 1] + iter3) - H(a0[i - 1], b0[i - 1], c0[i - 1] - iter3)) / 2 / iter3;

                DET[i - 1] = det(f_x[i - 1], f_y[i - 1], f_z[i - 1], g_x[i - 1], g_y[i - 1], g_z[i - 1], h_x[i - 1], h_y[i - 1], h_z[i - 1]);


                D_x[i - 1] = det(-f[i - 1], f_y[i - 1], f_z[i - 1], -g[i - 1], g_y[i - 1], g_z[i - 1], -h[i - 1], h_y[i - 1], h_z[i - 1]) / DET[i - 1];
                D_y[i - 1] = det(f_x[i - 1], -f[i - 1], f_z[i - 1], g_x[i - 1], -g[i - 1], g_z[i - 1], h_x[i - 1], -h[i - 1], h_z[i - 1]) / DET[i - 1];
                D_z[i - 1] = det(f_x[i - 1], f_y[i - 1], -f[i - 1], g_x[i - 1], g_y[i - 1], -g[i - 1], h_x[i - 1], h_y[i - 1], -h[i - 1]) / DET[i - 1];


                a0[i] = a0[i - 1] + D_x[i - 1];
                b0[i] = b0[i - 1] + D_y[i - 1];
                c0[i] = c0[i - 1] + D_z[i - 1];

                Console.WriteLine("For {0} th step: ", i);
                //Console.WriteLine("Dx, Dy, Dz for this step are: {0}, {1}, {2}", D_x[i - 1], D_y[i - 1], D_z[i - 1]);
                //Console.WriteLine(" "); 
                Console.WriteLine("A,b,q for this step are: {0}, {1}, {2}", a0[i - 1], b0[i - 1], c0[i - 1]);
                //Console.WriteLine(" "); 
                Console.WriteLine("P,Mx,My for this step are: {0}, {1}, {2}", F1[i - 1], G1[i - 1], H1[i - 1]);
                //Console.WriteLine(" ");
                Console.WriteLine("delta P, delta Mx, delta My for this step are: {0}, {1}, {2}", f[i - 1], g[i - 1], h[i - 1]);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                if (Math.Abs(f[i - 1]) + Math.Abs(g[i - 1]) + Math.Abs(h[i - 1]) < 1)
                {
                    Console.WriteLine("Value Found");
                    Console.WriteLine("it is the {0} th step", i);
                    break;
                }
            }


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

    }
}


































