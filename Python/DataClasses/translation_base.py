""" Translation Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class TranslationBase:
    translation_id: str = None
    created_time: time = None
    name: str = None
    custom_description: str = None
    id: int = None
    is_clockwise: bool = None
    cells: str = None
    cell_pattern_translations: str = None
    description: str = None
