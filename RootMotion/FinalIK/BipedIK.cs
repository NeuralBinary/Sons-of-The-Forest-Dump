using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x28F6670", Offset = "0x28F4C70", VA = "0x1828F6670")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x28F6700", Offset = "0x28F4D00", VA = "0x1828F6700")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x28F6790", Offset = "0x28F4D90", VA = "0x1828F6790")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x28F6820", Offset = "0x28F4E20", VA = "0x1828F6820")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x28F68B0", Offset = "0x28F4EB0", VA = "0x1828F68B0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x28F68E0", Offset = "0x28F4EE0", VA = "0x1828F68E0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x28F6910", Offset = "0x28F4F10", VA = "0x1828F6910")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x28F6970", Offset = "0x28F4F70", VA = "0x1828F6970")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x28F69D0", Offset = "0x28F4FD0", VA = "0x1828F69D0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x28F6A10", Offset = "0x28F5010", VA = "0x1828F6A10")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x28F6A40", Offset = "0x28F5040", VA = "0x1828F6A40")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x28F6AA0", Offset = "0x28F50A0", VA = "0x1828F6AA0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x28F6AE0", Offset = "0x28F50E0", VA = "0x1828F6AE0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x28F6BF0", Offset = "0x28F51F0", VA = "0x1828F6BF0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x28F6C20", Offset = "0x28F5220", VA = "0x1828F6C20")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x28F6C50", Offset = "0x28F5250", VA = "0x1828F6C50")]
		public void SetSpineWeight(float weight)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x28F6CA0", Offset = "0x28F52A0", VA = "0x1828F6CA0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x268E470", Offset = "0x268CA70", VA = "0x18268E470")]
		public void InitiateBipedIK()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2830D10", Offset = "0x282F310", VA = "0x182830D10")]
		public void UpdateBipedIK()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x28F6D10", Offset = "0x28F5310", VA = "0x1828F6D10")]
		public void SetToDefaults()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x28F6E70", Offset = "0x28F5470", VA = "0x1828F6E70", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x28F6F40", Offset = "0x28F5540", VA = "0x1828F6F40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x28F7350", Offset = "0x28F5950", VA = "0x1828F7350", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x28F7760", Offset = "0x28F5D60", VA = "0x1828F7760")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x28F77D0", Offset = "0x28F5DD0", VA = "0x1828F77D0")]
		public BipedIK()
		{
		}

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x40")]
		public BipedReferences references;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x48")]
		public BipedIKSolvers solvers;
	}
}
