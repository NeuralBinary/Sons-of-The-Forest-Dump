using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x297EEE0", Offset = "0x297D4E0", VA = "0x18297EEE0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x297EF70", Offset = "0x297D570", VA = "0x18297EF70")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x297F000", Offset = "0x297D600", VA = "0x18297F000")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x297F090", Offset = "0x297D690", VA = "0x18297F090")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x297F120", Offset = "0x297D720", VA = "0x18297F120")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x297F1B0", Offset = "0x297D7B0", VA = "0x18297F1B0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x297F240", Offset = "0x297D840", VA = "0x18297F240")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x297F2D0", Offset = "0x297D8D0", VA = "0x18297F2D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x297F360", Offset = "0x297D960", VA = "0x18297F360")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return 0f;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x297F3D0", Offset = "0x297D9D0", VA = "0x18297F3D0")]
		public void ResetRotation()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x297F4F0", Offset = "0x297DAF0", VA = "0x18297F4F0")]
		public void RotateTo(Vector3 position)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x29800B0", Offset = "0x297E6B0", VA = "0x1829800B0")]
		public InteractionTarget()
		{
		}

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0600052A RID: 1322 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Multiplier()
			{
			}

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}
	}
}
