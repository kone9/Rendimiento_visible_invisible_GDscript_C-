using Godot;
using System;
using System.Collections;

public class Node2D : Godot.Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    
    private ulong started;
    private int contador = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        started = OS.GetSystemTimeMsecs();  
    }
        

    //Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        GD.Print(contador);
        
        if (contador == 0)
        {
            //llamo a la función Visible invisible "1 MILLON" de veces
            for(int i = 0; i < 1000000; i++){
                prueba();
            }
        }
        
        else{
            var tiempoTranscurrido = OS.GetSystemTimeMsecs() - started;
			GD.Print("Result C#: ", tiempoTranscurrido);
			GetTree().Quit();
			return;
        }

        contador ++;
    }

    //funcion que va a ser llamada para hacer
    //visible invisible los nodos 3D
    private void prueba(){
        if (GetNode<MeshInstance>("cubo").Visible == false){
            GetNode<MeshInstance>("cubo").Visible = true;
            GetNode<MeshInstance>("triangulo").Visible = false;
        }
        else{
            GetNode<MeshInstance>("cubo").Visible = false;
            GetNode<MeshInstance>("triangulo").Visible = true;
        }   
   }

}
