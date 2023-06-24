using System;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Multiplayer;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
[AddComponentMenu("Sons/Level Props/Radio")]
public class Radio : BoltEntityBehaviourWrapper<IRadioState>
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2FF82D0", Offset = "0x2FF68D0", VA = "0x182FF82D0")]
	public static void SetDebugTextOn(bool value)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2FF8310", Offset = "0x2FF6910", VA = "0x182FF8310")]
	private void Start()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2FF85D0", Offset = "0x2FF6BD0", VA = "0x182FF85D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2FF8610", Offset = "0x2FF6C10", VA = "0x182FF8610")]
	private void SetupPlayback()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2FF8660", Offset = "0x2FF6C60", VA = "0x182FF8660")]
	private void SetupRandomTracks()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2FF8A00", Offset = "0x2FF7000", VA = "0x182FF8A00")]
	private void InterleaveAdverts()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2FF8B80", Offset = "0x2FF7180", VA = "0x182FF8B80", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2FF91D0", Offset = "0x2FF77D0", VA = "0x182FF91D0")]
	private void ServerStartRadio()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2FF9200", Offset = "0x2FF7800", VA = "0x182FF9200")]
	private void OnOffChanged()
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2FF92C0", Offset = "0x2FF78C0", VA = "0x182FF92C0")]
	private void SendRadioEvent(Radio.RadioEvent radioEventType)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2FF93D0", Offset = "0x2FF79D0", VA = "0x182FF93D0")]
	public void OnReceivedActivateEvent(RadioActivate ev)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2FF9490", Offset = "0x2FF7A90", VA = "0x182FF9490")]
	private void RandomHashChanged()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2FF9590", Offset = "0x2FF7B90", VA = "0x182FF9590")]
	private void InitializeRandom()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2FF96B0", Offset = "0x2FF7CB0", VA = "0x182FF96B0")]
	private int GetRandomHash()
	{
		return 0;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2FF9740", Offset = "0x2FF7D40", VA = "0x182FF9740")]
	private void ClientBrokenChanged()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2FF9760", Offset = "0x2FF7D60", VA = "0x182FF9760")]
	private void BrokenChanged()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2FF9880", Offset = "0x2FF7E80", VA = "0x182FF9880")]
	private void RadioTrackHashChanged()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2FF9B30", Offset = "0x2FF8130", VA = "0x182FF9B30")]
	private int GetTrackFromHash(int stateTrackHash)
	{
		return 0;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2FF9C40", Offset = "0x2FF8240", VA = "0x182FF9C40")]
	private void OnValidate()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2FF9D80", Offset = "0x2FF8380", VA = "0x182FF9D80")]
	public void OnBroken()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2FF9EC0", Offset = "0x2FF84C0", VA = "0x182FF9EC0")]
	private void UpdateBrokenNetwork()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2FFA080", Offset = "0x2FF8680", VA = "0x182FFA080")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2FFA0E0", Offset = "0x2FF86E0", VA = "0x182FFA0E0")]
	[ContextMenu("PlayNextSong")]
	private void PlayNextSong()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2FFA1C0", Offset = "0x2FF87C0", VA = "0x182FFA1C0")]
	private void SetRandomSongTime()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2FFA260", Offset = "0x2FF8860", VA = "0x182FFA260")]
	public void StartEvent(string eventName)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2FFA750", Offset = "0x2FF8D50", VA = "0x182FFA750")]
	private int GetAdvertIndex(string eventName)
	{
		return 0;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2FFA8C0", Offset = "0x2FF8EC0", VA = "0x182FFA8C0")]
	public void StopEvent(bool immediate)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2FFA920", Offset = "0x2FF8F20", VA = "0x182FFA920")]
	private void UserInputPowerOnOff()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2FFA9A0", Offset = "0x2FF8FA0", VA = "0x182FFA9A0")]
	private void UserInputNextSong()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2FFAA00", Offset = "0x2FF9000", VA = "0x182FFAA00")]
	private void PowerOnOff()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2FFAB50", Offset = "0x2FF9150", VA = "0x182FFAB50")]
	private void SetRadioOn(bool newActive, bool playOnOffSound)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2FFAE90", Offset = "0x2FF9490", VA = "0x182FFAE90")]
	public void OnGrabEnter()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2FFAEC0", Offset = "0x2FF94C0", VA = "0x182FFAEC0")]
	public void OnGrabExit()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2FFAEE0", Offset = "0x2FF94E0", VA = "0x182FFAEE0")]
	private void ToggleIcon(bool enable)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2FFAFB0", Offset = "0x2FF95B0", VA = "0x182FFAFB0")]
	private void EnableMusicStimuli(bool enable)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2FFB330", Offset = "0x2FF9930", VA = "0x182FFB330")]
	private float OnOffStateTime()
	{
		return 0f;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2FFB390", Offset = "0x2FF9990", VA = "0x182FFB390")]
	private void Update()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2FFB580", Offset = "0x2FF9B80", VA = "0x182FFB580")]
	private void UpdateInput()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2FFB7D0", Offset = "0x2FF9DD0", VA = "0x182FFB7D0")]
	private void UpdateDebug()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2FFBD60", Offset = "0x2FFA360", VA = "0x182FFBD60")]
	private bool IsPlayingEventFinished()
	{
		return default(bool);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2FFBD80", Offset = "0x2FFA380", VA = "0x182FFBD80")]
	private void ServerControllerUpdate()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2FFC160", Offset = "0x2FFA760", VA = "0x182FFC160")]
	private void UpdateEventPosition()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2FFC320", Offset = "0x2FFA920", VA = "0x182FFC320")]
	public Radio()
	{
	}

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _startOn;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Tooltip("When player is this close, start playing if stopped")]
	private float _startPlayDistance;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Tooltip("Stop event entirely beyond this distance")]
	private float _stopPlayDistance;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool _randomizeOrder;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x3D")]
	[Tooltip("Track will start as some random point in time")]
	[SerializeField]
	private bool _startRandomSongTime;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Range(0f, 1f)]
	[Tooltip("What sound parameter the radio will use")]
	private float _radioSoundSize;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _interactIcon;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RadioTrackList _trackList;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<string> _songEvents;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<string> _advertEvents;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool _advertsEnabled;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int _minSongsBetweenAdverts;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[EventRef]
	private string _turnOnEvent;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[EventRef]
	private string _turnOffEvent;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Material _onMaterial;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Material _offMaterial;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Renderer _screenRenderer;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GrabNode _grabNode;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float _volume;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private MonoBehaviourStimuli _musicStimuliPrefab;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private MonoBehaviourStimuli _pickupStimuli;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject _debugTextGroup;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private TMP_Text _debugText;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private UnityEvent _networkBrokenCallback;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0xD0")]
	private MonoBehaviourStimuli _musicStimuliInstance;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0xD8")]
	private bool _isOn;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0xD9")]
	private bool _grabEnabled;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0xDA")]
	private bool _isBroken;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0xDC")]
	private float _lastPowerSwitchTime;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0xE0")]
	private bool _isEventPlaying;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0xE4")]
	private float _eventTimeSec;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xE8")]
	private float _eventLengthSec;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xEC")]
	private int _playlistIdx;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0xF0")]
	private EventInstance _playingEvent;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xF8")]
	private System.Random _random;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x100")]
	private int _currentPlayListIndex;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x104")]
	private int _randomHash;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x0")]
	private static bool _debugTextOn;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x108")]
	private string _lastSongEvent;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x110")]
	private int _lastSongEventHash;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x118")]
	private List<string> _orderedEvents;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x120")]
	private List<string> _orderedAdvertEvents;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x128")]
	private bool _isPlayingAdvert;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	private enum RadioEvent
	{
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		OnOff,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		NextTrack,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		Broken
	}
}
