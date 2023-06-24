using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class WindManager : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2D53370", Offset = "0x2D51970", VA = "0x182D53370")]
		private void OnValidate()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2D534A0", Offset = "0x2D51AA0", VA = "0x182D534A0")]
		private void Awake()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2D53750", Offset = "0x2D51D50", VA = "0x182D53750")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2D53940", Offset = "0x2D51F40", VA = "0x182D53940")]
		public static void Register(IWindReceiver receiver)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2D53AE0", Offset = "0x2D520E0", VA = "0x182D53AE0")]
		private void RegisterInternal(IWindReceiver receiver)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2D53B70", Offset = "0x2D52170", VA = "0x182D53B70")]
		public static void Unregister(IWindReceiver receiver)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2D53D00", Offset = "0x2D52300", VA = "0x182D53D00")]
		private void UpdateReceivers()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2D54250", Offset = "0x2D52850", VA = "0x182D54250")]
		private void UnregisterInternal(IWindReceiver receiver)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2D542D0", Offset = "0x2D528D0", VA = "0x182D542D0")]
		private void Update()
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2D54530", Offset = "0x2D52B30", VA = "0x182D54530")]
		private void UpdateWindLoop()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2D54830", Offset = "0x2D52E30", VA = "0x182D54830")]
		public static void SetStormIntensityMultiplier(float intensityMultiplier)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2D54950", Offset = "0x2D52F50", VA = "0x182D54950")]
		private void SetStormMultiplier(float stormMultipler)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2D54960", Offset = "0x2D52F60", VA = "0x182D54960")]
		public static void SetAndLockIntensity(float intensity)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2D54A90", Offset = "0x2D53090", VA = "0x182D54A90")]
		public static void Unlock()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2D54BB0", Offset = "0x2D531B0", VA = "0x182D54BB0")]
		private void UnlockInternal()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2D54BC0", Offset = "0x2D531C0", VA = "0x182D54BC0")]
		private void SetIntensityInternal(float intensity, bool locked = false)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2D54DC0", Offset = "0x2D533C0", VA = "0x182D54DC0")]
		public static bool IsRegistered(IWindReceiver receiver)
		{
			return default(bool);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2D54E70", Offset = "0x2D53470", VA = "0x182D54E70")]
		public WindManager()
		{
		}

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x0")]
		private static WindManager _instance;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<IWindReceiver> Receivers;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int WindDirId;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int WindAmountId;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WindZone _windZone;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _remap;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _windLoop;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _stormIntenstityLerpSpeed;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x3C")]
		private bool _lock;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x40")]
		private float _startTime;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x44")]
		private float _stormIntensityMultiplier;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x48")]
		private float _appliedStormIntensityMultiplier;
	}
}
