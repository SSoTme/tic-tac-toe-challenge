""" LanguageToken Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class LanguageTokenBase:
    language_token_id: str = None
    created_time: time = None
    name: str = None
    display_name: str = None
    sort_order: int = None
    token: str = None
