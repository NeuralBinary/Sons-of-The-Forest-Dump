using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.FieldOfView
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class FovManager : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2FCCDC0", Offset = "0x2FCB3C0", VA = "0x182FCCDC0")]
		private void Update()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2FCD2D0", Offset = "0x2FCB8D0", VA = "0x182FCD2D0")]
		private void ClearTransitionsSettings()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2FCD390", Offset = "0x2FCB990", VA = "0x182FCD390")]
		private void ApplyTestSettings()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2FCD3A0", Offset = "0x2FCB9A0", VA = "0x182FCD3A0")]
		private void ClearTestSettings()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2FCD3E0", Offset = "0x2FCB9E0", VA = "0x182FCD3E0")]
		private float GetCurveMultiplier(float factor)
		{
			return 0f;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2FCD420", Offset = "0x2FCBA20", VA = "0x182FCD420")]
		public void Unregister(UnityEngine.Object source, FovManager.FieldOfViewChangeSettings settings)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2FCD450", Offset = "0x2FCBA50", VA = "0x182FCD450")]
		public void Unregister(UnityEngine.Object source, float returnSpeed, AnimationCurve curve)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2FCD650", Offset = "0x2FCBC50", VA = "0x182FCD650")]
		public bool RegisterAbsolute(UnityEngine.Object source, float target, float speed, AnimationCurve curve)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2FCD720", Offset = "0x2FCBD20", VA = "0x182FCD720")]
		public bool RegisterOffset(UnityEngine.Object source, FovManager.FieldOfViewChangeSettings settings)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2FCD820", Offset = "0x2FCBE20", VA = "0x182FCD820")]
		public bool RegisterOffset(UnityEngine.Object source, float offset, float speed, AnimationCurve curve)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2FCD900", Offset = "0x2FCBF00", VA = "0x182FCD900")]
		public static void SetGlobalOffset(int newValue)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2FCD940", Offset = "0x2FCBF40", VA = "0x182FCD940")]
		public FovManager()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const float InstantSwitchSpeed = 1000f;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _targetCamera;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private float _defaultFov;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		private float _currentTargetFieldOfView;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		private float _currentSpeed;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private FovManager.FieldOfViewChangeSettings _testSettings;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		private UnityEngine.Object _activeSource;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		private AnimationCurve _transitionCurve;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		private float _fullOffset;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private static int _globalOffset;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[Serializable]
		public class FieldOfViewChangeSettings
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600000F RID: 15 RVA: 0x000020C8 File Offset: 0x000002C8
			// (set) Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000001")]
			public float FieldOfViewTargetOffset
			{
				[Token(Token = "0x600000F")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000010")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000011 RID: 17 RVA: 0x000020E0 File Offset: 0x000002E0
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000002")]
			public float FieldOfViewTargetSpeed
			{
				[Token(Token = "0x6000011")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000012")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000013 RID: 19 RVA: 0x000020F6 File Offset: 0x000002F6
			// (set) Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000003")]
			public AnimationCurve FieldOfViewTargetSpeedCurve
			{
				[Token(Token = "0x6000013")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000014")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000015 RID: 21 RVA: 0x000020FC File Offset: 0x000002FC
			// (set) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000004")]
			public float FieldOfViewReturnSpeed
			{
				[Token(Token = "0x6000015")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000016")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000017 RID: 23 RVA: 0x000020F6 File Offset: 0x000002F6
			// (set) Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000005")]
			public AnimationCurve FieldOfViewReturnSpeedCurve
			{
				[Token(Token = "0x6000017")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000018")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2FCD990", Offset = "0x2FCBF90", VA = "0x182FCD990")]
			public FieldOfViewChangeSettings()
			{
			}
		}
	}
}
