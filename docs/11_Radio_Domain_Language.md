A gateway belső nyelve ezeket a commandokat, eventeket és state-eket ismeri és használja. A nevek az általános rádiós nomenklatura szerint lettek elnevezve.

Command/Requests
SetOpFrequency
SetBand
SetMode
SetVolumeInt
BeginTransmit
EndTransmit
SetTxPower
SetVolumeExt
SetSquelch
SetRFPreamp
SetRFGain
SetATT
SetPowerRadio1
SetPowerRadio2
SetTune
SetNoiseReduction
SetSelectedStation

Events
OpFrequencyChanged
BandChanged
ModeChanged
VolumeChangedInt
PTTChanged
TransmitStarted
TransmitStopped
TxPowerChanged
VolumeChangedExt
SquelchChanged
RFPreampChanged
RFGainChanged
ATTChanged
RigConnected
RigDisconnected
TuneChanged
NoiseReductionChanged
SelectedStationChanged

State
OpFrequency
Band
Mode
VolumeInt
TransmitState
TxPower
VolumeExt
Squelch
RFPreamp
RFGain
ATT
PowerRadio1
PowerRadio2
Tune
NoiseReduction
SelectedStation

Open Questions
Powered, connected, active radios, ID-s?
