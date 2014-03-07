namespace image_move_date
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhotoPathSrc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhotoPathDstBase = new System.Windows.Forms.TextBox();
            this.txtPhotoPathDst = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "移動元";
            // 
            // txtPhotoPathSrc
            // 
            this.txtPhotoPathSrc.AllowDrop = true;
            this.txtPhotoPathSrc.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhotoPathSrc.Location = new System.Drawing.Point(62, 12);
            this.txtPhotoPathSrc.Name = "txtPhotoPathSrc";
            this.txtPhotoPathSrc.Size = new System.Drawing.Size(623, 20);
            this.txtPhotoPathSrc.TabIndex = 19;
            this.txtPhotoPathSrc.TextChanged += new System.EventHandler(this.txtPhotoPathSrc_TextChanged);
            this.txtPhotoPathSrc.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPhotoPathSrc_DragDrop);
            this.txtPhotoPathSrc.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPhotoPathSrc_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "移動先";
            // 
            // txtPhotoPathDstBase
            // 
            this.txtPhotoPathDstBase.AllowDrop = true;
            this.txtPhotoPathDstBase.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhotoPathDstBase.Location = new System.Drawing.Point(62, 38);
            this.txtPhotoPathDstBase.Name = "txtPhotoPathDstBase";
            this.txtPhotoPathDstBase.Size = new System.Drawing.Size(623, 20);
            this.txtPhotoPathDstBase.TabIndex = 21;
            this.txtPhotoPathDstBase.TextChanged += new System.EventHandler(this.txtPhotoPathDstBase_TextChanged);
            this.txtPhotoPathDstBase.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPhotoPathDstBase_DragDrop);
            this.txtPhotoPathDstBase.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPhotoPathDstBase_DragEnter);
            // 
            // txtPhotoPathDst
            // 
            this.txtPhotoPathDst.AllowDrop = true;
            this.txtPhotoPathDst.Enabled = false;
            this.txtPhotoPathDst.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhotoPathDst.Location = new System.Drawing.Point(62, 64);
            this.txtPhotoPathDst.Name = "txtPhotoPathDst";
            this.txtPhotoPathDst.Size = new System.Drawing.Size(623, 20);
            this.txtPhotoPathDst.TabIndex = 23;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(62, 90);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(79, 37);
            this.btnMove.TabIndex = 24;
            this.btnMove.Text = "移動実行";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(17, 142);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(668, 134);
            this.txtResult.TabIndex = 26;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 289);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtPhotoPathDst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhotoPathDstBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhotoPathSrc);
            this.Name = "frmMain";
            this.Text = "画像を日付フォルダへ移動";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhotoPathSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhotoPathDstBase;
        private System.Windows.Forms.TextBox txtPhotoPathDst;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtResult;
    }
}

