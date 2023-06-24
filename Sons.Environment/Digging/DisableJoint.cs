using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class DisableJoint : DirtClump
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2FAEF80", Offset = "0x2FAD580", VA = "0x182FAEF80", Slot = "6")]
		internal override Action<Collider> GetTriggerActivateCallBack()
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2FAEFF0", Offset = "0x2FAD5F0", VA = "0x182FAEFF0", Slot = "5")]
		internal override Action<Collision> GetCollisionActivateCallBack()
		{
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2FAF060", Offset = "0x2FAD660", VA = "0x182FAF060", Slot = "4")]
		internal override Action GetOnEnableActivateCallback()
		{
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2FAF0D0", Offset = "0x2FAD6D0", VA = "0x182FAF0D0")]
		private void ActivateClumps(Collision obj)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2FAF0D0", Offset = "0x2FAD6D0", VA = "0x182FAF0D0")]
		private void ActivateClumps(Collider obj)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2FAF0E0", Offset = "0x2FAD6E0", VA = "0x182FAF0E0")]
		private void DisableDynamics()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2FAF230", Offset = "0x2FAD830", VA = "0x182FAF230")]
		private void ActivateClumps()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2FAD760", Offset = "0x2FABD60", VA = "0x182FAD760")]
		public DisableJoint()
		{
		}

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _disableDynamics;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _autoDestroy;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Joint> _joints;
	}
}
