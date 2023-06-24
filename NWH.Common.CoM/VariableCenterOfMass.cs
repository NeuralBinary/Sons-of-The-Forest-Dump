using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.CoM
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Rigidbody))]
	public class VariableCenterOfMass : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000001")]
		public Vector3 CenterOfMass
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x26E87A0", Offset = "0x26E6DA0", VA = "0x1826E87A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26E88F0", Offset = "0x26E6EF0", VA = "0x1826E88F0")]
		private void Awake()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26E8990", Offset = "0x26E6F90", VA = "0x1826E8990")]
		private void OnValidate()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26E8A30", Offset = "0x26E7030", VA = "0x1826E8A30")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x26E8B70", Offset = "0x26E7170", VA = "0x1826E8B70")]
		public void UpdateCoM()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x26E8D40", Offset = "0x26E7340", VA = "0x1826E8D40")]
		public void UpdateInertiaTensor()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x26E8D90", Offset = "0x26E7390", VA = "0x1826E8D90")]
		public void SyncAffectors()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26E8E30", Offset = "0x26E7430", VA = "0x1826E8E30")]
		public Vector3 CalculateCenterOfMass()
		{
			return default(Vector3);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x26E9250", Offset = "0x26E7850", VA = "0x1826E9250")]
		public Vector3 CalculateInertiaTensor(Vector3 dimensions)
		{
			return default(Vector3);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26E9680", Offset = "0x26E7C80", VA = "0x1826E9680")]
		private void UpdateRigidbodyProperties()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26E9840", Offset = "0x26E7E40", VA = "0x1826E9840")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26EA180", Offset = "0x26E8780", VA = "0x1826EA180")]
		private void Reset()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26EA590", Offset = "0x26E8B90", VA = "0x1826EA590")]
		public VariableCenterOfMass()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Base mass of the object, without IMassAffectors.")]
		public float baseMass;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Total mass of the object with masses of IMassAffectors counted in.")]
		public float totalMass;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Object dimensions in [m]. X - width, Y - height, Z - length.\r\nIt is important to set the correct dimensions or otherwise inertia might be calculated incorrectly.")]
		public Vector3 dimensions;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("AerodynamicCenter of mass of the rigidbody. Needs to be readjusted when new colliders are added.")]
		public Vector3 centerOfMass;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Used to adjust actual center of mass location in reference to the auto-calculated center of mass.")]
		public Vector3 centerOfMassOffset;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("When true inertia settings will be ignored and default Rigidbody inertia tensor will be used.")]
		public bool useDefaultInertia;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("    Vector by which the inertia tensor of the rigidbody will be scaled on Start().\r\n    Due to the unform density of the rigidbodies, versus the very non-uniform density of a vehicle, inertia can feel\r\n    off.\r\n    Use this to adjust inertia tensor values.")]
		public Vector3 inertiaTensor;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Used to adjust result given by automatic inertia calculation.")]
		public Vector3 inertiaScale;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Update interval in seconds.\r\nOn each update center of mass and inertia tensor will be updated based on values from IMassAffectors.")]
		public float updateInterval;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public IMassAffector[] affectors;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x78")]
		private Rigidbody _rigidbody;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x80")]
		private float _timer;
	}
}
