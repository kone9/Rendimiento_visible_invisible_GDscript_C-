extends Spatial


# Declare member variables here. Examples:
# var a = 2
# var b = "text"

var started
var contador = 0

# Called when the node enters the scene tree for the first time.
func _ready():
	started = OS.get_system_time_msecs()
	
	

func _process(delta):
	print(contador)
	
	if contador == 0:
		#llamo a la función Visible invisible "1 MILLON" de veces
		for i in range(0,1000000):
			prueba()
	
	
	#sino imprimo por pantalla el tiempo que tardo en llamarlas
	else:
		var tiempoTranscurrido = OS.get_system_time_msecs() - started;
		print("Result Gdscript#: ", tiempoTranscurrido);
		get_tree().quit()
		return	
	contador += 1

#funcion que va a ser llamada para hacer
#visible invisible los nodos 3D
func prueba():
	if $cubo.visible == false:
		#yield(get_tree().create_timer(1.0),"timeout")
		$cubo.visible = true
		$triangulo.visible = false
	else:
		#yield(get_tree().create_timer(1.0),"timeout")
		$cubo.visible = false
		$triangulo.visible = true
	
