""" Cell Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class CellBase:
    cell_id: str = None
    created_time: time = None
    name: str = None
    clockwise: str = None
    counter_clockwise: str = None
    flip: str = None
    sample_value: str = None
    description: str = None
    x: int = None
    y: int = None
    rotate_translation: str = None
    cell_index: int = None
    cell_pattern_cells: str = None
    cell_patterns: str = None
    current_cell_state: str = None
    default_cell_state: str = None
    cell_key: int = None
    is_clockwise: bool = None
    clockwise_rotate_from: str = None
    counter_clockwise_rotate_from: str = None
    rotate_from: str = None
    rotate_description: str = None
    clockwise_rotate_from_index: int = None
    counter_clockwise_rotate_from_index: int = None
    rotate_index: int = None
    default_state: str = None
    current_state: str = None
    flip_index: int = None
    flip_from_name: str = None
    flip_description: str = None
    sort_order: int = None
    is_daily_double: bool = None
