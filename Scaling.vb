'---------------------
' Scaling script : select smaller of the two texts and gives the same scaling to both. 
' Maxsize should be put on parent container
'---------------------
' Description 		: Applique la plus petite valeur de scale aux deux text containers
' Auteur 			: ANIK Myriam
' Date 				: 04/10/2021
'---------------------


dim container_A as Container = this.findsubcontainer("NAME_1")
dim container_B as Container = this.findsubcontainer("NAME_2")

sub OnInit()
	scene.findcontainer("NAME_1").geometry.RegisterTextChangedCallback()
	scene.findcontainer("NAME_2").geometry.RegisterTextChangedCallback()
end sub


sub OnGeometryChanged(geom As Geometry)
	container_A.Scaling.x =  Min(container_A.Scaling.x,container_B.Scaling.x)
	container_B.Scaling.x =  Min(container_A.Scaling.x,container_B.Scaling.x) 
	container_A.Scaling.y =  Min(container_A.Scaling.y,container_B.Scaling.y) 
	container_B.Scaling.y =  Min(container_A.Scaling.y,container_B.Scaling.y) 
end sub
