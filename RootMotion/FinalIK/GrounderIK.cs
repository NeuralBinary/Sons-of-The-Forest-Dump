using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2900F20", Offset = "0x28FF520", VA = "0x182900F20", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2900FB0", Offset = "0x28FF5B0", VA = "0x182900FB0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2901040", Offset = "0x28FF640", VA = "0x182901040", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2901060", Offset = "0x28FF660", VA = "0x182901060")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2901310", Offset = "0x28FF910", VA = "0x182901310")]
		private void OnDisable()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2901490", Offset = "0x28FFA90", VA = "0x182901490")]
		private void Update()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2901C70", Offset = "0x2900270", VA = "0x182901C70")]
		private void Initiate()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x29025A0", Offset = "0x2900BA0", VA = "0x1829025A0")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2902AE0", Offset = "0x29010E0", VA = "0x182902AE0")]
		private void SetLegIK(int index)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2902F20", Offset = "0x2901520", VA = "0x182902F20")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2903370", Offset = "0x2901970", VA = "0x182903370")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2903650", Offset = "0x2901C50", VA = "0x182903650")]
		public GrounderIK()
		{
		}

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x48")]
		public IK[] legs;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x9C")]
		private bool solved;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;
	}
}
