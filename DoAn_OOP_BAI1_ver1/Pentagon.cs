﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    public class Pentagon : Shape
    {
        public Pentagon() : base() { }

        public Pentagon(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Pentagon() { }

        public override void Nhap()
        {
            base.Nhap();
        }

        public override void Ve()
        {
            //Console.WriteLine();
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("Ve Hinh Ngu Giac Deu");
            Console.ResetColor();
            Console.WriteLine("Ve khung Hinh Ngu Giac Deu: ");
            Console.WriteLine("| 1_None | 2_Hidden | 3_Dotted | 4_Dashed | 5_Solid | 6_Double | 7_Groove | 8_Ridge | 9_Inset | 10_Outset |");
            Console.Write("Your choice => ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Khong Ve Khung");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Khung An");
                        this.DKVe();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Khung Cham");
                        this.DKVe();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Khung Gach");
                        this.DKVe();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Khung Solid");
                        this.DKVe();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Khung Double");
                        this.DKVe();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Khung Groove");
                        this.DKVe();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Khung Ridge");
                        this.DKVe();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Khung Inset");
                        this.DKVe();
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Khung Outset");
                        this.DKVe();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                        break;
                    }
            }
        }

        public override void changeColor()
        {
            base.changeColor();
        }

        public new void changeColor(int color)
        {
            base.changeColor(color);
        }

        public override void Move()
        {
            base.Move();
        }

        public new void Move(Point p1)
        {
            base.Move(p1);
        }

        public override void PhongTo()
        {
            base.PhongTo();
        }

        public override void ThuNho()
        {
            base.ThuNho();
        }

        public double BanKinhKhungTronNgoaiTiep()
        {
            double temp = Math.Abs(this.P1.x - this.P2.x);
            return temp / 2;
        }

        public double CanhNguGiacDeu()
        {
            double tmp = 50 + 10 * Math.Sqrt(5);
            double temp = Math.Sqrt(tmp) / 10;
            return this.BanKinhKhungTronNgoaiTiep() / temp;
        }

        public override double DienTich()
        {
            double temp = 25 + (10 * Math.Sqrt(5));
            double DienTich = (Math.Sqrt(temp) / 4) * Math.Pow(this.CanhNguGiacDeu(), 2);
            return DienTich;
        }

        public override double ChuVi()
        {
            return 5 * this.CanhNguGiacDeu();
        }

        public override void Xuat()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~PENTAGON~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("      Toa Do 1: "); this.P1.Xuat(); Console.Write("             Toa Do 2: "); this.P2.Xuat(); Console.WriteLine("             Mau sac: " + Console.ForegroundColor);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine("Canh cua Hinh Ngu Giac Deu la: " + this.CanhNguGiacDeu());

            //Console.WriteLine("Dien Tich Hinh Ngu Giac Deu la: " + this.DienTich());
        }

        public override void Menu()
        {
            int flag = 1;
            //Pentagon this = new Pentagon();
            //this.Nhap();
            try
            {
                if (Math.Abs(this.P1.x - this.P2.x) == Math.Abs(this.P1.y - this.P2.y) && (this.P1.x != this.P2.x && this.P1.y != this.P2.y))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Ngu Giac den Vi Tri moi    ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Ngu Giac                     ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Ngu Giac                          ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Ngu Giac                   ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Ngu Giac                      ***");
                        Console.WriteLine("\t\t\t\t***           6. Phong To                                  ***");
                        Console.WriteLine("\t\t\t\t***           7. Thu Nho                                   ***");
                        Console.WriteLine("\t\t\t\t***           8. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    do
                                    {
                                        this.Move();
                                    }
                                    while (Math.Abs(this.P1.x - this.P2.x) != Math.Abs(this.P1.y - this.P2.y));
                                    this.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    this.changeColor();
                                    this.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    this.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Ngu Giac Deu la: " + this.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tron la: " + this.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    this.PhongTo();
                                    this.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    this.ThuNho();
                                    this.Xuat();
                                    break;
                                }
                            case 8:
                                {
                                    flag = 0;
                                    Console.Clear();
                                    break;
                                }
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                                    break;
                                }
                        }
                    }
                }
                else
                    throw new Exception("Khong the ve hinh ngu giac deu voi khung hinh chu nhat!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
