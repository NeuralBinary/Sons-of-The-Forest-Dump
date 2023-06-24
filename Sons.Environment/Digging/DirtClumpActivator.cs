using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class DirtClumpActivator : DirtClump
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2FAD7B0", Offset = "0x2FABDB0", VA = "0x182FAD7B0", Slot = "6")]
		internal override Action<Collider> GetTriggerActivateCallBack()
		{
			return null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2FAD820", Offset = "0x2FABE20", VA = "0x182FAD820", Slot = "5")]
		internal override Action<Collision> GetCollisionActivateCallBack()
		{
			return null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2FAD890", Offset = "0x2FABE90", VA = "0x182FAD890", Slot = "4")]
		internal override Action GetOnEnableActivateCallback()
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2FAD900", Offset = "0x2FABF00", VA = "0x182FAD900")]
		private void ActivateClumps(Collision obj)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2FAD900", Offset = "0x2FABF00", VA = "0x182FAD900")]
		private void ActivateClumps(Collider obj)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2FAD910", Offset = "0x2FABF10", VA = "0x182FAD910")]
		private void DisableDynamics()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2FADA60", Offset = "0x2FAC060", VA = "0x182FADA60")]
		private void ActivateClumps()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2FADB00", Offset = "0x2FAC100", VA = "0x182FADB00")]
		private IEnumerator ActivateClumpsRoutine()
		{
			return null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2FADB90", Offset = "0x2FAC190", VA = "0x182FADB90")]
		private void SelfDestruct()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2FADCE0", Offset = "0x2FAC2E0", VA = "0x182FADCE0")]
		public DirtClumpActivator()
		{
		}

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _disableDynamics;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _autoDestroy;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GameObject> _clumps;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _deparent;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _stagger;
	}
}
