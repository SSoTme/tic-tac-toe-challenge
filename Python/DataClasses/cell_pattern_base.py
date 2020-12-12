""" CellPattern Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class CellPatternBase:
    cell_pattern_id: str = None
    created_time: time = None
    name: str = None
    description: str = None
    is_win_pattern: bool = None
    cell_pattern_cells: str = None
    cell_pattern_translations: str = None
    target_cell: str = None
    target_cell_state: str = None
    sort_order: int = None
    target_cell_state_id: int = None
    cell_pattern_cell_states: int = None
    cells: str = None
    target_cell_index: int = None
    target: int = None
    cell_pattern_translation_codes: int = None
    translations: str = None
