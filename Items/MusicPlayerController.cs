using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	[AddComponentMenu("Sons/Items/MusicPlayerController")]
	public class MusicPlayerController : MonoBehaviour
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x17000704")]
		public bool IsPowerOn
		{
			[Token(Token = "0x60037B4")]
			[Address(RVA = "0x8C87D0", Offset = "0x8C77D0", VA = "0x1808C87D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x2EB8410", Offset = "0x2EB7410", VA = "0x182EB8410")]
		private void Start()
		{
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x2EB8610", Offset = "0x2EB7610", VA = "0x182EB8610")]
		private void Update()
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x2EB7EC0", Offset = "0x2EB6EC0", VA = "0x182EB7EC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x2EB85A0", Offset = "0x2EB75A0", VA = "0x182EB85A0")]
		public bool TryGetActiveEvent(out EventInstance eventInstance)
		{
			return default(bool);
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x2EB8280", Offset = "0x2EB7280", VA = "0x182EB8280")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x2EB85D0", Offset = "0x2EB75D0", VA = "0x182EB85D0")]
		public void TurnOn()
		{
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x2EB85C0", Offset = "0x2EB75C0", VA = "0x182EB85C0")]
		public void TurnOff()
		{
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x2EB7F60", Offset = "0x2EB6F60", VA = "0x182EB7F60")]
		public void PlayNextSong()
		{
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x2EB8200", Offset = "0x2EB7200", VA = "0x182EB8200")]
		private void SetRandomSongTime()
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x2EB82D0", Offset = "0x2EB72D0", VA = "0x182EB82D0")]
		public void StartEvent(string eventName)
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x2EB8560", Offset = "0x2EB7560", VA = "0x182EB8560")]
		public void StopEvent(bool immediate)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x2EB80E0", Offset = "0x2EB70E0", VA = "0x182EB80E0")]
		private void SetRadioOn(bool enable, bool playOnOffSound)
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x2A0E810", Offset = "0x2A0D810", VA = "0x182A0E810")]
		private static bool IsEventFinished(EventInstance instance)
		{
			return default(bool);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x2EB86F0", Offset = "0x2EB76F0", VA = "0x182EB86F0")]
		public MusicPlayerController()
		{
		}

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _startOn;

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _randomizeOrder;

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x22")]
		[Tooltip("Track will start as some random point in time")]
		[SerializeField]
		private bool _startRandomSongTime;

		// Token: 0x04002FB3 RID: 12211
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("What sound parameter will the radio use")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _radioSoundSize;

		// Token: 0x04002FB4 RID: 12212
		[Token(Token = "0x4002FB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _songEvents;

		// Token: 0x04002FB5 RID: 12213
		[Token(Token = "0x4002FB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _turnOnEvent;

		// Token: 0x04002FB6 RID: 12214
		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		private string _turnOffEvent;

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _volume;

		// Token: 0x04002FB8 RID: 12216
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private bool _isPowerOn;

		// Token: 0x04002FB9 RID: 12217
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x45")]
		private bool _isEventPlaying;

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x48")]
		private EventInstance _playingEvent;

		// Token: 0x04002FBB RID: 12219
		[Token(Token = "0x4002FBB")]
		[FieldOffset(Offset = "0x50")]
		private int _playlistIdx;

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x58")]
		public Action<EventInstance> OnSongChanged;
	}
}
