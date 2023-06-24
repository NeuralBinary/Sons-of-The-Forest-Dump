using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class DirtClump : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000121 RID: 289 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000122 RID: 290 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000002")]
		private event Action<Collision> _collisionActivateCallback
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2FAC740", Offset = "0x2FAAD40", VA = "0x182FAC740")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2FAC8B0", Offset = "0x2FAAEB0", VA = "0x182FAC8B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000123 RID: 291 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000124 RID: 292 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000003")]
		private event Action<Collider> _triggerActivateCallback
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2FACA20", Offset = "0x2FAB020", VA = "0x182FACA20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2FACB90", Offset = "0x2FAB190", VA = "0x182FACB90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000125 RID: 293 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000126 RID: 294 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000004")]
		private event Action _onEnableActivateCallback
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2FACD00", Offset = "0x2FAB300", VA = "0x182FACD00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2FACDF0", Offset = "0x2FAB3F0", VA = "0x182FACDF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
		public void SetDynamicActive(bool value)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2FACEE0", Offset = "0x2FAB4E0", VA = "0x182FACEE0")]
		private bool IsReady()
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2FACF50", Offset = "0x2FAB550", VA = "0x182FACF50")]
		private void Awake()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		internal virtual Action GetOnEnableActivateCallback()
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "5")]
		internal virtual Action<Collision> GetCollisionActivateCallBack()
		{
			return null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "6")]
		internal virtual Action<Collider> GetTriggerActivateCallBack()
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2FAD370", Offset = "0x2FAB970", VA = "0x182FAD370")]
		private void OnEnable()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2FAD3D0", Offset = "0x2FAB9D0", VA = "0x182FAD3D0")]
		private void Update()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2FAD460", Offset = "0x2FABA60", VA = "0x182FAD460")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2FAD460", Offset = "0x2FABA60", VA = "0x182FAD460")]
		private void CheckActivateTrigger(Collider other)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2FAD530", Offset = "0x2FABB30", VA = "0x182FAD530")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2FAD530", Offset = "0x2FABB30", VA = "0x182FAD530")]
		private void OnCollisionStay(Collision other)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2FAD540", Offset = "0x2FABB40", VA = "0x182FAD540")]
		private void CheckActivateCollision(Collision other)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2FAD6F0", Offset = "0x2FABCF0", VA = "0x182FAD6F0")]
		private bool CanActivate()
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2FAD700", Offset = "0x2FABD00", VA = "0x182FAD700")]
		private void ActivateTrigger(Collider other)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2FAD720", Offset = "0x2FABD20", VA = "0x182FAD720")]
		private void ActivateCollision(Collision other)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2FAD740", Offset = "0x2FABD40", VA = "0x182FAD740")]
		private void ActivateOnEnable()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2FAD760", Offset = "0x2FABD60", VA = "0x182FAD760")]
		public DirtClump()
		{
		}

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _maxActivations;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _delay;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayRandomize;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _tagWhiteList;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _onEnable;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ReadOnly]
		private float _currentTime;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x44")]
		private int _activatedCount;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x48")]
		private float _startTime;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x68")]
		private bool _dynamicActive;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x6C")]
		private float _cachedDelay;
	}
}
