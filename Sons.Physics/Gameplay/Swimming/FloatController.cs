using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay.Swimming
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class FloatController : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x30F7020", Offset = "0x30F5620", VA = "0x1830F7020")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x30F7A00", Offset = "0x30F6000", VA = "0x1830F7A00")]
		private void OnDisable()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x30F7A10", Offset = "0x30F6010", VA = "0x1830F7A10")]
		private void OnEnable()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x30F7B40", Offset = "0x30F6140", VA = "0x1830F7B40")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x30F82F0", Offset = "0x30F68F0", VA = "0x1830F82F0")]
		private void ResetWaterValues()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x30F8360", Offset = "0x30F6960", VA = "0x1830F8360")]
		private void ApplyPhysicsDrag()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x30F84A0", Offset = "0x30F6AA0", VA = "0x1830F84A0")]
		private void RevertPhysicsDrag()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x30F85C0", Offset = "0x30F6BC0", VA = "0x1830F85C0")]
		private void UpdateWaterForce()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x30F90B0", Offset = "0x30F76B0", VA = "0x1830F90B0")]
		private static Vector3 CalculateScatterForce(FloatController.FloatLocation eachFloatPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x30F90F0", Offset = "0x30F76F0", VA = "0x1830F90F0")]
		private static float ScalarPerlinNoise(float x, float y)
		{
			return 0f;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30F9110", Offset = "0x30F7710", VA = "0x1830F9110")]
		private float CalculateFluidPressureFluctuation()
		{
			return 0f;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x30F9270", Offset = "0x30F7870", VA = "0x1830F9270")]
		public float CalculateAreaUnderWater(float radius, float posY, float waterBoundsYMax)
		{
			return 0f;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x30F92F0", Offset = "0x30F78F0", VA = "0x1830F92F0")]
		public FloatController()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<FloatController.FloatLocation> _floatPoints;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _applyPhysicsDrag;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _activeDrag;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _activeAngularDrag;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxWaterForce;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fluidDensity;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _fluidPressure;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		[Min(0f)]
		[SerializeField]
		private float _fluidPressureFluctuation;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _fluidPressureFluctuationSpeed;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _buoyancyFactor;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x60")]
		private bool _isInWater;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x64")]
		private float _waterLevel;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x68")]
		private float _waterDepth;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x70")]
		private List<FloatController.WaterForce> _waterForces;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x78")]
		private List<FloatController.WaterForce> _gizmoForces;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ForceMode _forceMode;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x84")]
		private float _pressureFluctuationGoalTimer;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x88")]
		private float _lastPressureFluctuationGoal;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x8C")]
		private float _pressureFluctuationGoal;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x90")]
		private bool _appliedRigidbodyDrag;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x94")]
		private float _defaultDrag;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x98")]
		private float _defaultAngularDrag;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x9C")]
		private float _totalForceMag;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xA0")]
		private float _totalWaterForceFactor;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xA4")]
		private bool _drawGizmos;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		private struct WaterForce
		{
			// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xFA1160", Offset = "0xF9F760", VA = "0x180FA1160")]
			public WaterForce(Vector3 pos, Vector3 force)
			{
			}

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Position;

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 Force;
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		[Serializable]
		public class FloatLocation
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public void OnDrawGizmos()
			{
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000020CC File Offset: 0x000002CC
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x30F9400", Offset = "0x30F7A00", VA = "0x1830F9400")]
			public Vector3 GetScatterForce()
			{
				return default(Vector3);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x30F9600", Offset = "0x30F7C00", VA = "0x1830F9600")]
			public FloatLocation()
			{
			}

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 _location;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x1C")]
			public float _radius;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x20")]
			public float _scatterForce;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x24")]
			public float _scatterSpeed;

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x28")]
			private float _scatterGoalTimer;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x2C")]
			private Vector3 _lastScatterGoal;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x38")]
			private Vector3 _scatterGoal;
		}
	}
}
