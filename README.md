# visualize the temperature change inside a room

## The application allows the user to build the room structure by clicking on the room area (panel) such that each click change the clicked cell into one of the following cell types: 

###* Normal Cell
This cell represents default cell room with temperature of Tr. The temperature of this kind of cells is modified, over time, by averaging the temperatures of the rounding cells together with its own temperature. 

###* Cold Cell
This cell represents an air conditioner that has a permanent temperature of Tc. The temperature of this kind of cells does not change over time. 

###* Heater Cell
This cell represents a heater that has a permanent temperature of Th. The temperature of this kind of cells does not change over time. 

###* Block Cell
This cell represents a wall that is heat-proof. The temperature of this kind of cells neither changes over time nor affect the surrounding cells.

###* Window Cell
This cell represents a window that has a temperature of Tw. The temperature of this kind of cells does not change over time but affects the surrounding cells over time. This cell shall have a border (or any other mark) to differentiate it from Normal Cell.



