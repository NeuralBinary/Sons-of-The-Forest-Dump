using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[RequireComponent(typeof(Anchor))]
	[Serializable]
	public class AdvancedShipController : Vehicle
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public Anchor Anchor
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x17000031")]
		public float SpeedKnots
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x270B440", Offset = "0x2709A40", VA = "0x18270B440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x270B460", Offset = "0x2709A60", VA = "0x18270B460")]
		public void Start()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x270BC70", Offset = "0x270A270", VA = "0x18270BC70")]
		public void Update()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x270BCA0", Offset = "0x270A2A0", VA = "0x18270BCA0", Slot = "5")]
		public override void FixedUpdate()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x270C420", Offset = "0x270AA20", VA = "0x18270C420", Slot = "6")]
		public override void Sleep()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x270C680", Offset = "0x270AC80", VA = "0x18270C680", Slot = "7")]
		public override void Wake()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x270C8B0", Offset = "0x270AEB0", VA = "0x18270C8B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x270D3B0", Offset = "0x270B9B0", VA = "0x18270D3B0")]
		public float GetPitchAngle()
		{
			return 0f;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x270D760", Offset = "0x270BD60", VA = "0x18270D760")]
		public float GetRollAngle()
		{
			return 0f;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x270DB10", Offset = "0x270C110", VA = "0x18270DB10")]
		private float WrapAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x270DB30", Offset = "0x270C130", VA = "0x18270DB30")]
		public AdvancedShipController()
		{
		}

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Tooltip("Handles all of the user input.")]
		public ShipInputHandler input;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Tooltip("List of engines. Each engine is a propulsion system in itself consisting of the engine and the propeller.")]
		public List<Engine> engines;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Tooltip("List of rudders.")]
		public List<Rudder> rudders;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("List of either bow or stern thrusters.")]
		[SerializeField]
		public List<Thruster> thrusters;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0xB8")]
		public bool dropAnchorWhenInactive;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0xB9")]
		public bool weighAnchorWhenActive;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xBA")]
		public bool stabilizeRoll;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0xBB")]
		public bool stabilizePitch;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xBC")]
		public float maxStabilizationTorqueAngle;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xC0")]
		public float rollStabilizationMaxTorque;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xC4")]
		public float pitchStabilizationMaxTorque;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 _stabilizationTorque;
	}
}
