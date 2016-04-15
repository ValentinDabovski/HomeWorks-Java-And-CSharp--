import javax.swing.*;
import java.awt.*;

public class Display {

    private JFrame frame;
    private Canvas canvas;

    private String title;
    private int width;
    private int height;

    public Display(String title, int width, int height) {
        this.title = title;
        this.width = width;
        this.height = height;
        crateDisplay();
    }

    private void crateDisplay(){

        frame = new JFrame(title);
        frame.setSize(this.width,this.height);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);

        canvas = new Canvas();
        canvas.setPreferredSize(new Dimension(this.width,this.height));
        canvas.setMaximumSize(new Dimension(this.width,this.height));
        canvas.setMinimumSize(new Dimension(this.width,this.height));

        frame.add(canvas);
        frame.pack();

    }

    public Canvas getCanvas() {
        return canvas;
    }

}
