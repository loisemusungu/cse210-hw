using System;

_reference: Reference;
_words: List<Word>;

Scripture(Reference : Reference, Text : string);

HideRandomWords(numberToHide : int): void;

GetDisplayText(): string;

IsCompletelyHidden(): bool;