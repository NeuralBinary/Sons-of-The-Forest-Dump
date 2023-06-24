using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2987A80", Offset = "0x2986080", VA = "0x182987A80")]
		public void SetDefaultLocalRotation()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2987B50", Offset = "0x2986150", VA = "0x182987B50")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2987B60", Offset = "0x2986160", VA = "0x182987B60")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2987F30", Offset = "0x2986530", VA = "0x182987F30")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x29880D0", Offset = "0x29866D0", VA = "0x1829880D0")]
		public void Disable()
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x17000093")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2988170", Offset = "0x2986770", VA = "0x182988170")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2988190", Offset = "0x2986790", VA = "0x182988190")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x000041CC File Offset: 0x000023CC
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x14B6A50", Offset = "0x14B5050", VA = "0x1814B6A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x600057E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		// Token: 0x0600057F RID: 1407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2988230", Offset = "0x2986830", VA = "0x182988230")]
		private void Awake()
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x29883F0", Offset = "0x29869F0", VA = "0x1829883F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x28F7760", Offset = "0x28F5D60", VA = "0x1828F7760")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2988400", Offset = "0x2986A00", VA = "0x182988400")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2988650", Offset = "0x2986C50", VA = "0x182988650")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x29888A0", Offset = "0x2986EA0", VA = "0x1829888A0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2988980", Offset = "0x2986F80", VA = "0x182988980")]
		protected RotationLimit()
		{
		}

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 axis;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x3D")]
		private bool initiated;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x3E")]
		private bool applicationQuit;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x3F")]
		private bool defaultLocalRotationSet;
	}
}
