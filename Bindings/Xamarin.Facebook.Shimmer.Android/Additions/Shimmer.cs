using Android.Animation;
using Android.Runtime;
using Java.Interop;

namespace Facebook.Shimmer
{
    public partial class Shimmer : global::Java.Lang.Object
    {
        public abstract partial class Builder : global::Java.Lang.Object
        {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setAutoStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register("setAutoStart", "(Z)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetAutoStart_ZHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetAutoStart(bool status)
			{
				const string __id = "setAutoStart.(Z)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(status);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setBaseAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setBaseAlpha", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetBaseAlpha_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetBaseAlpha(float alpha)
			{
				const string __id = "setBaseAlpha.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(alpha);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setClipToChildren' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register("setClipToChildren", "(Z)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetClipToChildren_ZHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetClipToChildren(bool status)
			{
				const string __id = "setClipToChildren.(Z)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(status);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setDirection", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetDirection_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetDirection(int direction)
			{
				const string __id = "setDirection.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(direction);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setDropoff' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setDropoff", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetDropoff_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetDropoff(float dropoff)
			{
				const string __id = "setDropoff.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(dropoff);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register("setDuration", "(J)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetDuration_JHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetDuration(long millis)
			{
				const string __id = "setDuration.(J)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(millis);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setFixedHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setFixedHeight", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetFixedHeight_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetFixedHeight(int fixedHeight)
			{
				const string __id = "setFixedHeight.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(fixedHeight);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setFixedWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setFixedWidth", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetFixedWidth_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetFixedWidth(int fixedWidth)
			{
				const string __id = "setFixedWidth.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(fixedWidth);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setHeightRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setHeightRatio", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetHeightRatio_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetHeightRatio(float heightRatio)
			{
				const string __id = "setHeightRatio.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(heightRatio);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setHighlightAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setHighlightAlpha", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetHighlightAlpha_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetHighlightAlpha(float alpha)
			{
				const string __id = "setHighlightAlpha.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(alpha);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setIntensity", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetIntensity_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetIntensity(float intensity)
			{
				const string __id = "setIntensity.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(intensity);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setRepeatCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setRepeatCount", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetRepeatCount_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetRepeatCount(int repeatCount)
			{
				const string __id = "setRepeatCount.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(repeatCount);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setRepeatDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register("setRepeatDelay", "(J)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetRepeatDelay_JHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetRepeatDelay(long millis)
			{
				const string __id = "setRepeatDelay.(J)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(millis);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setRepeatMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setRepeatMode", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetRepeatMode_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetRepeatMode(ValueAnimatorRepeatMode mode)
			{
				const string __id = "setRepeatMode.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((int)mode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setShape' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register("setShape", "(I)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetShape_IHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetShape(int shape)
			{
				const string __id = "setShape.(I)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(shape);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setTilt' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setTilt", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetTilt_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetTilt(float tilt)
			{
				const string __id = "setTilt.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(tilt);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.shimmer']/class[@name='Shimmer.Builder']/method[@name='setWidthRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register("setWidthRatio", "(F)Lcom/facebook/shimmer/Shimmer$Builder;", "GetSetWidthRatio_FHandler")]
			public virtual unsafe global::Facebook.Shimmer.Shimmer.Builder SetWidthRatio(float widthRatio)
			{
				const string __id = "setWidthRatio.(F)Lcom/facebook/shimmer/Shimmer$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(widthRatio);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Facebook.Shimmer.Shimmer.Builder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

        public partial class AlphaHighlightBuilder : global::Facebook.Shimmer.Shimmer.Builder
        {
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override global::Java.Lang.Object RawThis
            {
                get
				{
                    try {
                        return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
                    } finally {
                    }
                }
            }
		}

		public partial class ColorHighlightBuilder : global::Facebook.Shimmer.Shimmer.Builder
        {
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override global::Java.Lang.Object RawThis
            {
                get
                {
                    try {
                        return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
                    } finally {
                    }
                }
            }
		}
	}
}