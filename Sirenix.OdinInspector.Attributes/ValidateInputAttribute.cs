using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	public sealed class ValidateInputAttribute : Attribute
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		[Obsolete("Use the ContinuousValidationCheck member instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ContiniousValidationCheck
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x25729C0", Offset = "0x2570FC0", VA = "0x1825729C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x25729D0", Offset = "0x2570FD0", VA = "0x1825729D0")]
			set
			{
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A8A9C0", Offset = "0x2A88FC0", VA = "0x182A8A9C0")]
		public ValidateInputAttribute(string condition, [Optional] string defaultMessage, InfoMessageType messageType = InfoMessageType.Error)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2A8A9C0", Offset = "0x2A88FC0", VA = "0x182A8A9C0")]
		[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput)
		{
		}

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DefaultMessage;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Condition;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoMessageType MessageType;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IncludeChildren;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool ContinuousValidationCheck;
	}
}
