using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[DefaultExecutionOrder(50)]
	[AddComponentMenu("Sons/Weapon/Attachment Manager")]
	public class AttachmentManager : MonoBehaviour
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x31986D0", Offset = "0x3196CD0", VA = "0x1831986D0")]
		public static void GetOffsets(Transform tr, Transform attachedTo, out Vector3 offset, out Quaternion rotationOffset)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3198AD0", Offset = "0x31970D0", VA = "0x183198AD0")]
		public static void AddAttachment(Transform tr, Transform attachedTo, bool notifyOnDisabled)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3198CC0", Offset = "0x31972C0", VA = "0x183198CC0")]
		public static void AddAttachment(Transform tr, Transform attachedTo, bool notifyOnDisabled, Vector3 offset, Quaternion rotationOffset)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3199090", Offset = "0x3197690", VA = "0x183199090")]
		public static void RemoveAttachment(Transform tr)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3199290", Offset = "0x3197890", VA = "0x183199290")]
		private static void RemoveAttachment(int i)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3199630", Offset = "0x3197C30", VA = "0x183199630")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AttachmentManager()
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		private static List<AttachmentManager.Attachment> _attachments;

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		[Serializable]
		private class Attachment
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x0000233C File Offset: 0x0000053C
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x3199810", Offset = "0x3197E10", VA = "0x183199810")]
			public bool Update()
			{
				return default(bool);
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Attachment()
			{
			}

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x10")]
			public Transform tr;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0x18")]
			public Transform attachedTo;

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 offset;

			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion rotationOffset;

			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x3C")]
			public bool notifyOnDisabled;
		}
	}
}
