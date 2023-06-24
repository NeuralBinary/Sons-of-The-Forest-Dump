using System;
using Endnight.Types;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;

namespace Sons.Gameplay
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class DedicatedServerAutosave : SingletonBehaviour<DedicatedServerAutosave>
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x30D11E0", Offset = "0x30CF7E0", VA = "0x1830D11E0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x30D1370", Offset = "0x30CF970", VA = "0x1830D1370")]
		private void OnEnable()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x30D1390", Offset = "0x30CF990", VA = "0x1830D1390")]
		private void OnDisable()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30D13B0", Offset = "0x30CF9B0", VA = "0x1830D13B0")]
		private void Update()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30D1610", Offset = "0x30CFC10", VA = "0x1830D1610")]
		private bool IsReadyToSave()
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x30D16B0", Offset = "0x30CFCB0", VA = "0x1830D16B0")]
		public static void QueueAutosave()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x30D1720", Offset = "0x30CFD20", VA = "0x1830D1720")]
		public DedicatedServerAutosave()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private RealtimeAutoTimer _timer;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		private bool _autosaveQueued;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x31")]
		private bool _initialPostCutsceneSaveQueued;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x32")]
		private bool _gameLoadedFromSave;
	}
}
