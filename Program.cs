Console.WriteLine ("---Simulador de luz de advertência---\n");
Console.WriteLine("[A]tivado,[D]esativado");
 
 Console.WriteLine ("sensor de temperatura...:");
 string entradaT =
 Console.ReadLine()?.Trim().ToUpper();

 Console.WriteLine ("Sensor de Pressão..:");
 string entradaP =
 Console.ReadLine()?.Trim().ToUpper();

 Console.WriteLine ("Sensor de rotação..:");
 string entradaR =
Console.ReadLine()?.Trim().ToUpper();


string Luz_Advertencial
Luz_Advertencial= entradaT == "A"&& (entradaP=="A" || entradaR=="A");

Console.WriteLine(Luz_Advertencial de advertencia (ativada:desativada))