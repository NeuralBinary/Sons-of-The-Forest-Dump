using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public abstract class DistanceActivationBase : MonoBehaviour, IThreadSafeTask
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		protected virtual bool StartShouldBeActive()
		{
			return default(bool);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
		protected virtual bool StartIsActive()
		{
			return default(bool);
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x00009948 File Offset: 0x00007B48
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000485")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x60020CE")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020CF")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
		protected void SetRadius(float radius)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		protected void SetActiveRadius(float activeRadius)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		protected void SetAnyPlayerInMultiplayer(bool anyPlayerInMultiplayer)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
		protected float GetRadius()
		{
			return 0f;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
		protected float GetActiveRadius()
		{
			return 0f;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x17000486")]
		protected bool AnyPlayerInMultiplayer
		{
			[Token(Token = "0x60020D5")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x331DEA0", Offset = "0x331C4A0", VA = "0x18331DEA0")]
		public void SetTransformPosition(Vector3 position)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x331DF70", Offset = "0x331C570", VA = "0x18331DF70", Slot = "11")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x331E0D0", Offset = "0x331C6D0", VA = "0x18331E0D0")]
		private void RegisterWorkScheduler()
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x331E180", Offset = "0x331C780", VA = "0x18331E180")]
		public void CheckWorkSchedulerBucket()
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x331E1F0", Offset = "0x331C7F0", VA = "0x18331E1F0", Slot = "12")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x331E230", Offset = "0x331C830", VA = "0x18331E230")]
		private void UnregisterWorkScheduler()
		{
		}

		// Token: 0x060020DC RID: 8412
		[Token(Token = "0x60020DC")]
		public abstract string GetTaskName();

		// Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x331E260", Offset = "0x331C860", VA = "0x18331E260", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
		protected virtual bool ShouldBeActive()
		{
			return default(bool);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x331E2C0", Offset = "0x331C8C0", VA = "0x18331E2C0", Slot = "15")]
		protected virtual bool ShouldBeActiveRangeCheck(float rangeOffset)
		{
			return default(bool);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x331E4B0", Offset = "0x331CAB0", VA = "0x18331E4B0", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x060020E1 RID: 8417
		[Token(Token = "0x60020E1")]
		protected abstract void MainThreadDeactivated();

		// Token: 0x060020E2 RID: 8418
		[Token(Token = "0x60020E2")]
		protected abstract void MainThreadActivated();

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		protected DistanceActivationBase()
		{
		}

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _radius;

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _anyPlayerInMultiplayer;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _bucketUpdateDistanceSqr;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x30")]
		private float _distanceToPlayer;

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x34")]
		private bool _isActive;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x35")]
		private bool _shouldBeActive;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x38")]
		private int _wsToken;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _transformPosition;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x48")]
		private bool _mainThreadRunning;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _lastWorkSchedulerPosition;
	}
}
