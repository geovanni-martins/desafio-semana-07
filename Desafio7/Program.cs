List<int> gastos = new List<int>();
int totalGastos = 0;

gastos.Add(150);
gastos.Add(250);
gastos.Add(400);
gastos.Add(80);

for (int i = 0; i < gastos.Count; i++) {
    totalGastos += gastos[i];
}

Console.WriteLine($"Total gasto: ${totalGastos}");
Console.WriteLine($"Média dos gastos: ${totalGastos / gastos.Count}");
string msg = (totalGastos / gastos.Count) > 200 ? "Gastos elevados" : "Gastos controlados";
Console.WriteLine(msg);