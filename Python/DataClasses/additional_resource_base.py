""" AdditionalResource Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class AdditionalResourceBase:
    additional_resource_id: str = None
    created_time: time = None
    name: str = None
    description: str = None
    type: str = None
    google_key: str = None
    g_i_d: int = None
    is_active_download: bool = None
