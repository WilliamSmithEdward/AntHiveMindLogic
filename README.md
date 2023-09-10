# AntHiveMindLogic

This is a personal project to model the behavior of ants as they scout for food and establish pheromone scent trails that guide other ants in the colony to the food source.

## Overview

* Ants use pheromone trails to communicate with one another. 
* When an ant finds food, it lays down a pheromone trail on its way back to the colony.
* Other ants sense this trail and follow it to the food source.
* Over time, the strongest and shortest paths are reinforced by multiple ants following and reinforcing the same trail.

## GeoGrid

The purpose of the GeoGrid is to model terrain on which an ant may move about, and food may be placed to attract the ant.

### Properties

* **Rows**: List of `GridRow` objects. Represents the rows of the grid.
* **Columns**: List of `GridColumn` objects. Represents the columns of the grid.
* **Cells**: List of `GridCell` objects. Represents the cells within the grid.

### Methods

* **GetNewGeoGrid(int gridSize) -> GeoGrid?**: A static method that returns a new `GeoGrid` object of the specified size, with initialized cells, rows, and columns.
* **PlaceAntAtRandomLocationOnGrid()**: Places an ant at a random cell location on the grid which does not already have food.
* **PlaceFoodAtRandomLocationOnGrid()**: Places food at a random cell location on the grid which does not already have an ant.
