'---------------------
' JUMPS TO FIRST TAKE
'---------------------
' Description 		: Bypass transition of the child scene in the main scene
'---------------------

sub OnInitParameters()
	RegisterParameterDouble("time", "Time", 0.5, 0.0, 999.99)
	RegisterPushButton("jump", "Jump To Start", 0)
end sub

sub OnExecAction(buttonId As Integer)
	jumpToStart()
end sub

sub jumpToStart()
	dim cCurrent as container = this.findsubcontainer("current")
	dim dCurrent as director = cCurrent.GetDirector()
	dCurrent.show(GetParameterDouble("time"))
end sub
