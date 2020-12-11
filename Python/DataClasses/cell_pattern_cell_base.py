""" CellPatternCell Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class CellPatternCellBase:
    cell_pattern_cell_id: str = None
    created_time: time = None
    cell: str = None
    cell_pattern: str = None
    cell_state: str = None
    name: str = None
    cell_index: int = None
    cell_state_id: int = None
    cell_cell_state: int = None
    cell_name: str = None
    cell_state_name: str = None
