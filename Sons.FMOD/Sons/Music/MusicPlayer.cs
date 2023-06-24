using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Music
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class MusicPlayer : MonoBehaviour
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2FE2960", Offset = "0x2FE0F60", VA = "0x182FE2960")]
		private void OnEnable()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2FE29C0", Offset = "0x2FE0FC0", VA = "0x182FE29C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2FE29F0", Offset = "0x2FE0FF0", VA = "0x182FE29F0")]
		private void Update()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2FE2A60", Offset = "0x2FE1060", VA = "0x182FE2A60")]
		private void Run()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
		public MusicPlayer()
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _stopMusic;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EventRef]
		private string _eventPath;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _allowOverrideEventPath;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _delayStart;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x38")]
		private float _enableTime;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x3C")]
		private bool _hasRun;
	}
}
