""" CellState Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class CellStateBase:
    cell_state_id: str = None
    created_time: time = None
    name: str = None
    code: str = None
    description: str = None
    color: str = None
    font_color: str = None
    default_mark: str = None
    cursor: str = None
    sort_order: int = None
    id: int = None
    cell_pattern_cells: str = None
    cell_patterns: str = None
    current_state_cells: str = None
    default_state_cells: str = None
