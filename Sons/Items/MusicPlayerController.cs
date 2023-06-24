using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	[AddComponentMenu("Sons/Items/MusicPlayerController")]
	public class MusicPlayerController : MonoBehaviour
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x1700067C")]
		public bool IsPowerOn
		{
			[Token(Token = "0x6003199")]
			[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600319A")]
		[Address(RVA = "0x348DAB0", Offset = "0x348C0B0", VA = "0x18348DAB0")]
		private void Start()
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x348DCC0", Offset = "0x348C2C0", VA = "0x18348DCC0")]
		private void Update()
		{
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x348DE60", Offset = "0x348C460", VA = "0x18348DE60")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x348DF00", Offset = "0x348C500", VA = "0x18348DF00")]
		public bool TryGetActiveEvent(out EventInstance eventInstance)
		{
			return default(bool);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600319E")]
		[Address(RVA = "0x348DF20", Offset = "0x348C520", VA = "0x18348DF20")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x348DF70", Offset = "0x348C570", VA = "0x18348DF70")]
		public void TurnOn()
		{
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A0")]
		[Address(RVA = "0x348DFB0", Offset = "0x348C5B0", VA = "0x18348DFB0")]
		public void TurnOff()
		{
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0x348DFC0", Offset = "0x348C5C0", VA = "0x18348DFC0")]
		public void PlayNextSong()
		{
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A2")]
		[Address(RVA = "0x348E140", Offset = "0x348C740", VA = "0x18348E140")]
		private void SetRandomSongTime()
		{
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A3")]
		[Address(RVA = "0x348E280", Offset = "0x348C880", VA = "0x18348E280")]
		public void StartEvent(string eventName)
		{
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0x348E3C0", Offset = "0x348C9C0", VA = "0x18348E3C0")]
		public void StopEvent(bool immediate)
		{
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x348E400", Offset = "0x348CA00", VA = "0x18348E400")]
		private void SetRadioOn(bool enable, bool playOnOffSound)
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x348E5D0", Offset = "0x348CBD0", VA = "0x18348E5D0")]
		private static bool IsEventFinished(EventInstance instance)
		{
			return default(bool);
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x348E660", Offset = "0x348CC60", VA = "0x18348E660")]
		public MusicPlayerController()
		{
		}

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _startOn;

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _randomizeOrder;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x22")]
		[Tooltip("Track will start as some random point in time")]
		[SerializeField]
		private bool _startRandomSongTime;

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("What sound parameter will the radio use")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _radioSoundSize;

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _songEvents;

		// Token: 0x04002AD1 RID: 10961
		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _turnOnEvent;

		// Token: 0x04002AD2 RID: 10962
		[Token(Token = "0x4002AD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _turnOffEvent;

		// Token: 0x04002AD3 RID: 10963
		[Token(Token = "0x4002AD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _volume;

		// Token: 0x04002AD4 RID: 10964
		[Token(Token = "0x4002AD4")]
		[FieldOffset(Offset = "0x44")]
		[HideInInspector]
		[SerializeField]
		private bool _isPowerOn;

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x45")]
		private bool _isEventPlaying;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x48")]
		private EventInstance _playingEvent;

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x50")]
		private int _playlistIdx;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		[FieldOffset(Offset = "0x58")]
		public Action<EventInstance> OnSongChanged;
	}
}
