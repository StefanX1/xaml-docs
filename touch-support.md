---
title: Touch Support
page_title: Touch Support
description: Touch Support
slug: touch-support
tags: touch,support
published: True
position: 10
---

# Touch Support

Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} now provides touch support. The functionality is built on top of an internally implemented framework to provide the needed extensibility and the ability for each of the specific controls in the suite to support only the needed for it gestures.
      
## Gestures

Touch gestures describe gestures in which you use a finger or stylus to a movement over a control or object on the screen. These are the commonly supported ones for the suite:

Gesture | - | Description 
---	|	---	|	---	
![Common Touch Support 01](images/Common_TouchSupport_01.png) | Swipe | The user presses and holds on the screen and then drags the finger / stylus in any direction.
![Common Touch Support 02](images/Common_TouchSupport_02.png)	|	Pinch	|	The user touches the screen with two (or more) fingers and moves them inwards or outwards.
![Common Touch Support 03](images/Common_TouchSupport_03.png)	|	Tap	|	The user touches the screen.
![Common Touch Support 04](images/Common_TouchSupport_04.png)	|	Tap and Move	|	The user presses and holds the screen for few seconds (between 600ms and 1500ms) and drags his finger / stylus in any direction.
![Common Touch Support 05](images/Common_TouchSupport_05.png)	|	Tap and Hold	|	The user presses and holds the screen for a few seconds (more than 1500ms).

## Controls Behavior

Below are listed the controls and their behavior with the different gestures:

Swipe	|	Pinch	|	Tap	|	Tap and Move	|	Tap and Hold	|	Custom
---	|	---	|	---	|	---	|	---	|	---
Next/Previous	|	Semantic zoom (only outwards)	|	Click	|	-	|	-	|	-
Scroll	|	Zoom	|	Click/Selection/Tooltip	|	Trackball	|	Show ToolTip	|	-
Scroll DropDown	|	-	|	Click	|	-	|	-	|	-
Scroll with inertia	|	-	|	Click	|	Scroll (if possible)	|	-	|	-
Pan	|	Zoom	|	Select	|	Scroll	|	-	|	-
Scroll with inertia	|	Zoom	|	Click	|	On item - Drag&Drop; on slot - Scroll	|	-	|	-
-	|	-	|	Click	|	Moves indicators	|	Shows tooltip	|	-
Scroll	|	-	|	Click	|	-	|	Shows a circle to be dragged	|	-
Scroll	|	Zoom	|	-	|	-	|	-	|	-
Scroll with inertia	|	-	|	Click	|	Drag&Drop	|	-	|	-
Scroll	|	-	|	Click/Selection	|	-	|	-	|	Double Tap -> Zoom
Scroll	|	Zoom	|	Click	|	-	|	-	|	Selection markers to extend the selection
Scroll	|	Zoom	|	Click (move caret to position)	|	-	|	Show context menu	|	Selection markers to extend the selection
Horizontally - Previous/Next	|	Semantic zoom	|	Click/Selection	|	On item - Drag&Drop; on slot - Scroll	|	-	|	-
	|		|		|		|		|	
Vertically - Scroll	|		|		|		|		|	
Scroll	|	Zoom	|	Click	|	-	|	-	|	Selection markers to extend the selection
Scroll	|	Zoom	|	Click/Selection	|	Moves Selection	|	Selection	|	Double Tap -> Extends selection
Scroll	|	Zoom	|	Click/Selection	|	Selection	|	Shows tooltip	|	-
Scroll	|	-	|	Click	|	-	|	Shows a circle to be dragged	|	-
-	|	-	|	Selection	|	-	|	Shows tooltip	|	-
Scroll	|	-	|	Select	|	Scroll	|	-	|	-
Scroll	|	-	|	Select	|	Reorder	|	-	|	-

## TouchManager States

As of version __Q2 2014__, we have introduced a new __IsTouchEnabled__ property, which __controls the state of TouchManager on application level__.
        
>importantThe property is of boolean type and its Default value is True.
          
__Setting it to False__ will destroy any existent TouchHandlers and unsubscribe from any MS TouchEvents internally. This will also prevent the further creation of such handlers until it is set back to True.
        
__Setting it to True on a later stage__ will again turn on the creation of new elements, however, it will not restore any of the previously disposed ones.
        
>In order to restore full touch support, you will need to reload the affected controls in the visual tree.
         
 