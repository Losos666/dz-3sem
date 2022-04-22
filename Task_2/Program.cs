double[]A1 = {3,6,8};
 double[]B1 = {2,1,-7};
double dx = A1[0] - B1[0];
double dy = A1[1] - B1[1];
double dz = A1[2] - B1[2];

double Di = Math.Sqrt (dx*dx+dy*dy+dz*dz);
System.Console.WriteLine ("$ растояние между точками  =  "+"{0:f2}", Di);
