A State Model a Gateway által ismert adatok alapján a rádió aktuális állapotának belső leképezése. A State nem az adott rádió memóriájának tükörképe (bár azzal minél nagyobb egyezést mutat), hanem az az állapot, amit a Gateway a driverektől kapott információk alapján érvényesnek lát.


STA-0001
OpFrequency
Category: Operating State
Type: uint
Unit: Hz
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0002
Band
Category: Operating State
Type: string (3.5MHz, 7MHz, 14MHz, 18MHz, 21MHz, 24MHz, 28MHz, Air, 144MHz, 430MHz)
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0003
Mode
Category: Operating State
Type: string (AM, LSB, USB, FM, CW-LSB, CW-USB, CW, DATA, DATA-LSB, DATE-USB)
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0004
VolumeInt
Category: Audio State
Type: byte
Unit: %
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0005
TransmitState
Category: Transmit state
Type: true/false
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0007
TxPower
Category: Transmit state
Type: byte
Unit: W
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0008
VolumeExt
Category: Audio State
Type: byte
Unit: %
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0009
Squelch
Category: Receiver State
Type: byte
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0010
RFPreamp
Category: Receiver State
Type: string (0, AMP1, AMP2)
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0011
RFGain
Category: Receiver State
Type: byte
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0012
ATT
Category: Receiver State
Type: string (OFF, ATT1, ATT2)
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0013
PowerRadio1
Category: Connection State
Type: true/false
Unit: 0
Writable: No
Source: Driver
Persistent: No
Published: Yes

STA-0014
PowerRadio2
Category: Connection State
Type: true/false
Unit: 0
Writable: No
Source: Driver
Persistent: No
Published: Yes

STA-0015
Tune
Category: Transmit state
Source:
Driver

STA-0016
NoiseReduction
Category: Receiver State
Type: byte
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0017
SelectedStation
Category: Operating State
Type: byte
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

STA-0018
MicGain
Category: Transmit state
Type: byte
Unit: 0
Writable: Yes
Source: Driver
Persistent: No
Published: Yes

State
Configuration





