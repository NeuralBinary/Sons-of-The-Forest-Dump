using System;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	public class FallingTreeTrunkNetworkProxy : BoltEntityBehaviourWrapper<ITreeFallState>
	{
		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x3580440", Offset = "0x357EA40", VA = "0x183580440")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x3580610", Offset = "0x357EC10", VA = "0x183580610")]
		private void OnValidate()
		{
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x3581670", Offset = "0x357FC70", VA = "0x183581670")]
		private void StripKinematics(Transform tr, Rigidbody targetRigidbody, Joint targetJoint)
		{
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x35818A0", Offset = "0x357FEA0", VA = "0x1835818A0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x3581F30", Offset = "0x3580530", VA = "0x183581F30")]
		private void OnUniformScaleChanged()
		{
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x3582060", Offset = "0x3580660", VA = "0x183582060")]
		private void ValidateData(Transform sectionGameObject, ref Rigidbody sectionRigidbody, ref Joint sectionJoint)
		{
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x3582320", Offset = "0x3580920", VA = "0x183582320")]
		public void DeactivatePhysics()
		{
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x35824B0", Offset = "0x3580AB0", VA = "0x1835824B0")]
		public FallingTreeTrunkNetworkProxy()
		{
		}

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private float _selfDestructTimer;

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _mpCutTopProxy;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _sectionA;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _sectionB;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _sectionC;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _sectionD;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Rigidbody _sectionARigidbody;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Rigidbody _sectionBRigidbody;

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Rigidbody _sectionCRigidbody;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Rigidbody _sectionDRigidbody;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Joint _sectionAJoint;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Joint _sectionBJoint;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Joint _sectionCJoint;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Joint _sectionDJoint;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0xA0")]
		private float _uniformScaleFromEntity;
	}
}
