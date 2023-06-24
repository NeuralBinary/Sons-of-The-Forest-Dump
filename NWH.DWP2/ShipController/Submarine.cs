using System;
using Il2CppDummyDll;
using NWH.Common.CoM;
using NWH.Common.Utility;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[RequireComponent(typeof(AdvancedShipController))]
	[RequireComponent(typeof(VariableCenterOfMass))]
	public class Submarine : MonoBehaviour
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002E64 File Offset: 0x00001064
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005B")]
		public float DepthInput
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x27174F0", Offset = "0x2715AF0", VA = "0x1827174F0")]
			set
			{
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2717520", Offset = "0x2715B20", VA = "0x182717520")]
		private void Awake()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2717600", Offset = "0x2715C00", VA = "0x182717600")]
		private void Start()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2717900", Offset = "0x2715F00", VA = "0x182717900")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2718140", Offset = "0x2716740", VA = "0x182718140")]
		public Submarine()
		{
		}

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Depth at which the submarine will aim to be at. This is achieved by changing the weight of the submarine's rigidbody.")]
		public float requestedDepth;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Speed of depth change in m/s when a key is used to change depth.")]
		public float depthInputSensitivity;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 10f)]
		[Tooltip("Integral term of the depth PID controller.")]
		public float depthPID_Kp;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Integral term of the depth PID controller.")]
		[Range(0f, 5f)]
		public float depthPID_Ki;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Derivative term of the depth PID controller.")]
		[Range(0f, 5f)]
		public float depthPID_Kd;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Maximum additional mass that can be added (taking on water) to the base mass of the rigidbody to make submarine sink.")]
		[Range(1f, 5f)]
		public float maxMassFactor;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If enabled submarine will try to keep horizontal by shifting the center of mass.")]
		public bool keepHorizontal;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Sensitivity of calculation trying to keep the submarine horizontal. Higher number will mean faster reaction.")]
		public float keepHorizontalSensitivity;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Maximum rigidbody center of mass offset that can be used to keep the submarine level.")]
		public float maxMassOffset;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody _rb;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x50")]
		private VariableCenterOfMass _com;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x58")]
		private float _initialMass;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _initialCom;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x68")]
		private float _depth;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x6C")]
		private float _mass;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x70")]
		private float _zOffset;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x78")]
		private AdvancedShipController _asc;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x80")]
		private float _depthError;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x88")]
		private PIDController _depthController;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private float depthInput;
	}
}
