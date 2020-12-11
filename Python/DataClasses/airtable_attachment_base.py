""" AirtableAttachment Class Definition """
import time
import uuid
from dataclasses import dataclass

@dataclass
class AirtableAttachmentBase:
    attachments_id: str = None
    url: str = None
    filename: str = None
    size: int = None
    type: str = None
