using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AddComponentMenu("Sons/Physics/Area Effector 3D")]
	public class AreaEffector3D : MonoBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x17000002")]
		private bool UseWhiteList
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x30FA3E0", Offset = "0x30F89E0", VA = "0x1830FA3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x17000003")]
		private bool UseBlackList
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x30FA3F0", Offset = "0x30F89F0", VA = "0x1830FA3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x30FA400", Offset = "0x30F8A00", VA = "0x1830FA400")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x30FA5F0", Offset = "0x30F8BF0", VA = "0x1830FA5F0")]
		private Vector3 CalculateWorldForceDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x30FA8A0", Offset = "0x30F8EA0", VA = "0x1830FA8A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x30FAA50", Offset = "0x30F9050", VA = "0x1830FAA50")]
		private void CleanAttached()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x30FAC80", Offset = "0x30F9280", VA = "0x1830FAC80")]
		private bool Matches(Component other)
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x30FAD00", Offset = "0x30F9300", VA = "0x1830FAD00")]
		private bool MatchesWhiteList(Component other)
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x30FAF10", Offset = "0x30F9510", VA = "0x1830FAF10")]
		private bool MatchesBlackList(Component other)
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x30FB120", Offset = "0x30F9720", VA = "0x1830FB120")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x30FB360", Offset = "0x30F9960", VA = "0x1830FB360")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x30FB400", Offset = "0x30F9A00", VA = "0x1830FB400")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
		public Vector3 GetForce()
		{
			return default(Vector3);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x29A0850", Offset = "0x299EE50", VA = "0x1829A0850")]
		public void SetForce(Vector3 force)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
		public void SetMultiplier(float forceMultiplier)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x30FB8D0", Offset = "0x30F9ED0", VA = "0x1830FB8D0")]
		public AreaEffector3D()
		{
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _force;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _forceMultiplier;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _scaleByDirection;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _scaleDirection;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _scaleDirectionAdditive;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TagFilterMode _tagFilterMode;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<string> _tagWhiteList;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<string> _tagBlackList;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x58")]
		private List<Collider> _attachedColliders;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x60")]
		private List<int> _affectedRigidbodies;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x68")]
		private int _lastUpdateFrame;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private static int _timeBetweenUpdates;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _worldForceDirection;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x78")]
		private bool _hasAttached;
	}
}
