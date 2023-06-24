using System;
using Endnight.Types;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Music
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class MusicManager : SingletonBehaviour<MusicManager>
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2FE2230", Offset = "0x2FE0830", VA = "0x182FE2230")]
		private bool IsEventInstanceValid()
		{
			return default(bool);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2FE2240", Offset = "0x2FE0840", VA = "0x182FE2240")]
		private void OnEnable()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2FE2300", Offset = "0x2FE0900", VA = "0x182FE2300")]
		public static void Stop()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2FE23B0", Offset = "0x2FE09B0", VA = "0x182FE23B0")]
		private void StopInternal()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2FE2420", Offset = "0x2FE0A20", VA = "0x182FE2420")]
		public void SetMusicEvent(string eventPath)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2FE2550", Offset = "0x2FE0B50", VA = "0x182FE2550")]
		private void VerifyEmitter()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2FE2740", Offset = "0x2FE0D40", VA = "0x182FE2740")]
		public static bool HasActiveEvent()
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2FE27B0", Offset = "0x2FE0DB0", VA = "0x182FE27B0")]
		public static void Play()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2FE2820", Offset = "0x2FE0E20", VA = "0x182FE2820")]
		public static void Play(string eventPath)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2FE2900", Offset = "0x2FE0F00", VA = "0x182FE2900")]
		public MusicManager()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		private string _activeEvent;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emitterGameObject;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		private IFMODEmitter _emitter;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _eventInstance;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x0")]
		private static string _musicQueue;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x48")]
		private bool _emitterStarted;
	}
}
