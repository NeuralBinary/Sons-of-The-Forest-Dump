using System;
using Endnight.Types;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class CoopPlayerAutosave : SingletonBehaviour<CoopPlayerAutosave>
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x30D0EC0", Offset = "0x30CF4C0", VA = "0x1830D0EC0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x30D0FB0", Offset = "0x30CF5B0", VA = "0x1830D0FB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x30D0FD0", Offset = "0x30CF5D0", VA = "0x1830D0FD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30D0FF0", Offset = "0x30CF5F0", VA = "0x1830D0FF0")]
		public static void QueueAutosave()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30D1080", Offset = "0x30CF680", VA = "0x1830D1080")]
		private void Update()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x30D1170", Offset = "0x30CF770", VA = "0x1830D1170")]
		public CoopPlayerAutosave()
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minimumAutosaveDelayDurationSeconds;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		private RealtimeAutoTimer _timer;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		private bool _autosaveQueued;
	}
}
