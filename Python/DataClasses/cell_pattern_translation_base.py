""" CellPatternTranslation Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class CellPatternTranslationBase:
    cell_pattern_translation_id: str = None
    created_time: time = None
    translation: str = None
    cell_pattern: str = None
    count: int = None
    sort_order: int = None
    name: str = None
    translation_id: int = None
    c_p_t_code: int = None
    cell_pattern_name: str = None
    translation_name: str = None
