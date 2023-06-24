using System;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Quality
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class DynamicResolutionScaler : SingletonBehaviour<DynamicResolutionScaler>
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3114E60", Offset = "0x3113460", VA = "0x183114E60")]
		private void OnEnable()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3114FC0", Offset = "0x31135C0", VA = "0x183114FC0")]
		private float ScalerFunction()
		{
			return 0f;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3115340", Offset = "0x3113940", VA = "0x183115340")]
		private void Update()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x31154F0", Offset = "0x3113AF0", VA = "0x1831154F0")]
		public static void SetActive(bool active)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3115550", Offset = "0x3113B50", VA = "0x183115550")]
		public static void SetFpsTarget(int fps)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x31155B0", Offset = "0x3113BB0", VA = "0x1831155B0")]
		public static void SetOverride(bool value, float scaler = 1f)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3115670", Offset = "0x3113C70", VA = "0x183115670")]
		public static float GetCurrentScale()
		{
			return 0f;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x31156C0", Offset = "0x3113CC0", VA = "0x1831156C0")]
		public DynamicResolutionScaler()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static bool _active;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x4")]
		private static int _fpsTrigger;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _smoothTime;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxSpeed;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _stepSize;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _underPerformingTriggerDiff;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _overPerformingTriggerDiff;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _minTimeBetweenChanges;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _overrideScaler;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _overrideScalerValue;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x48")]
		private float _currentScalar;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentUnclampedScalar;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		private float _currentTarget;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x54")]
		private float _currentFps;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x58")]
		private bool _underPerforming;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x5C")]
		private float _triggerDiff;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x60")]
		private RealtimeAutoTimer _lastChangedTimer;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<float> _frameTimings;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x70")]
		private int _sampleCount;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x74")]
		private float _totalTime;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x78")]
		private float _currentVel;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		private static float _scaledSize;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x7C")]
		private float _lastValidScalar;
	}
}
